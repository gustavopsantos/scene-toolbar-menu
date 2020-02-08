using System.Text;

internal static class Extensions
{
    public static string RemoveSpecialCharacters(this string str)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '_')
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}