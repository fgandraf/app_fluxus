using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fluxus.Api
{
    public class Util
    {

        public static dynamic DateOrNull(string data)
        {
            if (data != null)
                return Convert.ToDateTime(data);
            else
                return null;
        }

        public static string DateTimeToShortDateString(string date)
        {
            if (date != "")
                return Convert.ToDateTime(date).ToString("dd/MM/yyyy");
            else
                return null;
        }



    }
}
