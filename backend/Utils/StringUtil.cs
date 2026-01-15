namespace NzbWebDAV.Utils;

public static class StringUtil
{
    extension(string? str)
    {
        public string? OrNull() => str == "" ? null : str;
    }
}