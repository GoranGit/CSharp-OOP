namespace Extensions.StringBuilderExtensions
{
    using System;
using System.Text;

    public static class StringBuilderExceptions
    {
        public static StringBuilder Substring(this StringBuilder str,int startIndex,int length)
        {
            StringBuilder result = new StringBuilder();
            if (startIndex > str.Length - 1 || startIndex<0)
                throw new ArgumentOutOfRangeException("startIndex Index out of range!");
            if (startIndex + length > str.Length)
                throw new ArgumentOutOfRangeException("Index out of range! Lenght too long!");

            else
            {
                for(int i=startIndex;i<startIndex+length;i++)
                {
                    result.Append(str[i]);
                }
                return result;
            }
        }

    }
}
