using System;

namespace ClassLibrary3
{
    public static class Class1
    {
        public static bool StartsWithUpper(this string)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            char ch = str[0];
            return char.IsUpper(ch);
        }
    }
}
