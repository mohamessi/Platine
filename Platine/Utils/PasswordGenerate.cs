using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Platine.Utils
{
    public class PasswordGenerate
    {
        static Random r = new Random();
        public static string AleaPassword()
        {
            String res = "";
            for (int i = 0; i < 8; i++)
            {
                res += SelectChar(r.Next(0, 3));
            }
            return res;
        }

        public static char AleaUpperCase()
        {
            return (char)r.Next(65, 90);
        }

        public static char AleaLowerCase()
        {
            return (char)r.Next(97, 122);
        }

        public static int AleaInt()
        {
            return r.Next(0, 9);
        }
        public static String SelectChar(int i)
        {
            if( i == 1)
            {
                return AleaInt()+"";
            }
            else if( i == 2)
            {
                return AleaLowerCase()+"";
            }
            else
            {
                return AleaUpperCase()+"";
            }
        }
    }
}