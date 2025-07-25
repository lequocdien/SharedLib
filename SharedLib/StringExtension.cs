namespace SharedLib;

public static class StringExtension
{
    public static string ToMyLower(this string str)
    {
        return str.ToLower();
    }

    public static string ToMyUpper(this string str)
    {
        return str.ToUpper();
    }

    public static string ToMyLowerInvariant(this string str)
    {
        return str.ToLowerInvariant();
    }
    
    public static string ToMyUpperInvariant(this string str)
    {
        return str.ToUpperInvariant();
    }
}