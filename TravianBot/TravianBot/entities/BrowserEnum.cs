using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravianBot.entities
{
    class BrowserEnum
    {
        public enum Browser {  GoogleChrome = 0, Firefox = 1, InternetExplorer = 2, Invalid = -1};

        public static Browser getEnum(int index)
        {
            if(Enum.IsDefined(typeof(Browser),index))
            {
                return ((Browser)index);
            }
            else
            {
                return Browser.Invalid;
            }
        }
    }
}
