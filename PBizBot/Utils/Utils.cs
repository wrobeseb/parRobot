using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBizBot.Utils
{
    public class Utils
    {
        public static String RemoveAllNotNumberCharacters(String content)
        {
            content = content.Replace(" ", "");

            StringBuilder builder = new StringBuilder();
            foreach (char character in content.ToCharArray())
            {
                if ((int)character < 48 || (int)character > 57)
                {
                    builder.Append(" ");
                }
                else
                {
                    builder.Append(character);
                }
            }

            String tempString = builder.ToString();

            builder = new StringBuilder();

            foreach (String value in tempString.Split(' '))
            {
                if (!String.IsNullOrEmpty(value))
                {
                    builder.Append(value).Append(",");
                }
            }

            return builder.ToString().TrimEnd(',');
        }
    }
}
