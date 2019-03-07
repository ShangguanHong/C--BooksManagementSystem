using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagementSystem.Util
{
    class OtherUtil
    {
        public static string getWelcomeString()
        {
            int currentHour = int.Parse(DateTime.Now.ToString("HH"));
            if (currentHour > 6 && currentHour <= 12)
            {
                return "早上好";
            }
            else if (currentHour > 12 && currentHour <= 18)
            {
                return "下午好";
            }
            else
            {
                return "晚上好";
            }
        }
    }
}
