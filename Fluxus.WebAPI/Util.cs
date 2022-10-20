using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluxusAPI
{
    public class Util
    {

        public static dynamic DateOrNull(string data)
        {
            if (data == null)
                return null;
            else
                return Convert.ToDateTime(data);
        }

        public static string DateTimeToShortDateString(string date)
        {
            if (date == "")
                return string.Empty;
            else
                return Convert.ToDateTime(date).ToString("dd/MM/yyyy");
        }



    }
}
