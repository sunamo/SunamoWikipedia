namespace SunamoWikipedia._sunamo.SunamoExceptions;

/// <summary>
/// Provides utility methods for exception handling and stack trace inspection.
/// </summary>
internal sealed partial class Exceptions
{
    /// <summary>
    /// Checks and formats a prefix string for exception messages.
    /// </summary>
    /// <param name="prefix">The prefix text to check.</param>
    /// <returns>Empty string if null/whitespace, otherwise the prefix followed by colon and space.</returns>
    internal static string CheckBefore(string prefix)
    {
        return string.IsNullOrWhiteSpace(prefix) ? string.Empty : prefix + ": ";
    }

    /// <summary>
    /// Retrieves the place of exception from the current stack trace.
    /// </summary>
    /// <param name="isFillingAlsoFirstTwo">Whether to fill type and method name from the first matching frame.</param>
    /// <returns>A tuple containing type name, method name, and full stack trace text.</returns>
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

    /// <summary>
    /// Extracts type and method name from a stack trace line.
    /// </summary>
    /// <param name="line">The stack trace line to parse.</param>
    /// <param name="type">The extracted type name.</param>
    /// <param name="methodName">The extracted method name.</param>
    internal static void TypeAndMethodName(string line, out string type, out string methodName)
    {
        var afterAt = line.Split("at ")[1].Trim();
        var text = afterAt.Split('(')[0];
        var parts = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        methodName = parts[^1];
        parts.RemoveAt(parts.Count - 1);
        type = string.Join(".", parts);
    }

    /// <summary>
    /// Gets the name of the calling method at the specified stack depth.
    /// </summary>
    /// <param name="depth">The stack frame depth to retrieve.</param>
    /// <returns>The name of the calling method.</returns>
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

    /// <summary>
    /// Generates a not-implemented method exception message.
    /// </summary>
    /// <param name="prefix">The prefix text for the exception message.</param>
    /// <returns>A formatted exception message string.</returns>
    internal static string? NotImplementedMethod(string prefix)
    {
        return CheckBefore(prefix) + "Not implemented method.";
    }
}
