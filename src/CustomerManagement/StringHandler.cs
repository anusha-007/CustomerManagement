using System;

namespace CustomerManagement
{
    public static class StringHandler
    {
        public static string InsertSpaces(this string source)
        {
            var result = string.Empty;

            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }

                    result = result.Trim();
                    result += letter;
                }
                
            }

            return result;

        }
    }
}