using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Währungsrechner
{
    public class Rechner
    {
        public string Zeichen="Zeichnen";
        public static double Umwandlung(double a, string b)
        {
            double result = 0;
            double pfundk = 1.1668611435239206534422403733956; 
            double dollark = 0.85331512927724208550217595357966;
            if (b == "Euro")
            {
                result = a;
            }  
            else if (b == "Dollar")
            {
                result = a / dollark;
            }
            else if (b == "Pfund")
            {
                result = a / pfundk;
            } 
            result = Math.Round(result, 2);
            return result;
        }
        
    }
}
