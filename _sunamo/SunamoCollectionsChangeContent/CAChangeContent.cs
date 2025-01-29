namespace SunamoWikipedia._sunamo.SunamoCollectionsChangeContent;


internal class CAChangeContent
{
    private static void RemoveNullOrEmpty(ChangeContentArgsWikipedia a, List<string> files_in)
    {
        if (a != null)
        {
            if (a.removeNull)
            {
                files_in.Remove(null);
            }
            if (a.removeEmpty)
            {
                for (int i = files_in.Count - 1; i >= 0; i--)
                {
                    if (files_in[i].Trim() == string.Empty)
                    {
                        files_in.RemoveAt(i);
                    }
                }
            }
        }
    }
                    #region Vem obojí
    internal static List<string> ChangeContentSwitch12<Arg1>(List<string> files_in, Func<Arg1, string, string> func, Arg1 arg)
    {
        for (int i = 0; i < files_in.Count; i++)
        {
            files_in[i] = func.Invoke(arg, files_in[i]);
        }
        return files_in;
    }
        #endregion
    #region ChangeContent for easy copy
                #endregion
}