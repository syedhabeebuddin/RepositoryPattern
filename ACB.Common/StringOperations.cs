using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACB.Common
{
    public static class StringOperations
    {
        public static string InsertSpaces(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char ch in input)
            {
                if(char.IsUpper(ch))
                {
                    sb.Append(" ");
                }
                sb.Append(ch);
            }

            return sb.ToString();
        }
    }
}
