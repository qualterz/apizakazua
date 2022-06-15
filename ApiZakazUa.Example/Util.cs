namespace ApiZakazUa.Examples;

public static class Util
{
    public static string SeparateWithComma(IEnumerable<string> strings)
    {
        return string.Join(", ", strings);
    }
}