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
            if (data is null)
                return null; 
            
            return Convert.ToDateTime(data);                
        }

        public static string DateTimeToShortDateString(string date)
        {
            if (date is "" || date is null)
                return null;
            
            return Convert.ToDateTime(date).ToString("dd/MM/yyyy");   
        }

    }
}
