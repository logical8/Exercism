public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        return new List<string>{"C#", "Clojure", "Elm"};
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count();
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Any(l=>l == language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        var firstCondition = languages.Any() && languages.First() == "C#";
        var secondCondition = (CountLanguages(languages) == 2 || CountLanguages(languages) == 3) && languages[1] == "C#";
        return firstCondition || secondCondition;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        return languages.Count() == languages.ToHashSet().Count();
    }
}
