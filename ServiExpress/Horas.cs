using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiExpress
{
    public static class Horas
    {
        public static List<string> GetHoras()
        {
            List<string> horas = new List<string>();
            TimeSpan timeSpan = new TimeSpan(8,0,0);
            TimeSpan timeSpanAdd = new TimeSpan(0,45,0);

            for (int i = 0; horas.Count < 14 ; i++)
            {
                timeSpan = timeSpan + timeSpanAdd;
                horas.Add(timeSpan.ToString().Substring(0,5));
            }
            return horas;
        }

    }
}
