using System.Text;

internal static class Extensions
{
    internal static string RemoveSpecialCharacters(this string s)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '_')
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}