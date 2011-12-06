using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParafiaPRO.Core.Utils
{
    public abstract class Utils
    {
        public static int ConvertToInt(String content)
        {
            content = content.Replace(" ", "");

            StringBuilder builder = new StringBuilder();
            foreach (char character in content.ToCharArray())
                if ((int)character >= 48 && (int)character <= 57)
                    builder.Append(character);

            int value = 0;

            int.TryParse(builder.ToString(), out value);

            return value;
        }
    }
}
