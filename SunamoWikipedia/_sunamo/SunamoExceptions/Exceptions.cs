namespace SunamoWikipedia._sunamo.SunamoExceptions;

internal sealed partial class Exceptions
{
    internal static string CheckBefore(string prefix)
    {
        return string.IsNullOrWhiteSpace(prefix) ? string.Empty : prefix + ": ";
    }

    internal static Tuple<string, string, string> PlaceOfException(bool isFillingAlsoFirstTwo = true)
    {
        StackTrace stackTrace = new();
        var text = stackTrace.ToString();
        var lines = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
        lines.RemoveAt(0);
        var index = 0;
        string type = string.Empty;
        string methodName = string.Empty;
        for (; index < lines.Count; index++)
        {
            var line = lines[index];
            if (isFillingAlsoFirstTwo)
            {
                if (!line.StartsWith("   at ThrowEx"))
                {
                    TypeAndMethodName(line, out type, out methodName);
                    isFillingAlsoFirstTwo = false;
                }
            }

            if (line.StartsWith("at System."))
            {
                lines.Add(string.Empty);
                lines.Add(string.Empty);
                break;
            }
        }

        return new Tuple<string, string, string>(type, methodName, string.Join(Environment.NewLine, lines));
    }

    internal static void TypeAndMethodName(string line, out string type, out string methodName)
    {
        var afterAt = line.Split("at ")[1].Trim();
        var text = afterAt.Split('(')[0];
        var parts = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        methodName = parts[^1];
        parts.RemoveAt(parts.Count - 1);
        type = string.Join(".", parts);
    }

    internal static string CallingMethod(int depth = 1)
    {
        StackTrace stackTrace = new();
        var methodBase = stackTrace.GetFrame(depth)?.GetMethod();
        if (methodBase == null)
        {
            return "Method name cannot be get";
        }

        var methodName = methodBase.Name;
        return methodName;
    }

    internal static string? NotImplementedMethod(string prefix)
    {
        return CheckBefore(prefix) + "Not implemented method.";
    }
}
