internal static class Extensions
{
    // Method created by Felipe R. Machado
    // https://www.codeproject.com/Articles/1014073/Fastest-method-to-remove-all-whitespace-from-Strin
    internal static string TrimAll(this string s) {

        int length = s.Length;
        char[] src = s.ToCharArray();
        int dstIndex = 0;

        for (int i = 0; i < length; i++) {
            char c = src[i];

            // this is surprisingly faster than the equivalent if statement
            switch (c) {
                case '\u0020': case '\u00A0': case '\u1680': case '\u2000': case '\u2001':
                case '\u2002': case '\u2003': case '\u2004': case '\u2005': case '\u2006':
                case '\u2007': case '\u2008': case '\u2009': case '\u200A': case '\u202F':
                case '\u205F': case '\u3000': case '\u2028': case '\u2029': case '\u0009':
                case '\u000A': case '\u000B': case '\u000C': case '\u000D': case '\u0085':
                    continue;

                default:
                    src[dstIndex++] = c;
                    break;
            }
        }
        return new string(src, 0, dstIndex);
    }
}