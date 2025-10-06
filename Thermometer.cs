using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturkontroll
{
    internal class Thermometer
    {
        public double Temprature { get; set; }

        public void CheckTempretaure()
        {
            

            if (Temprature < 0)
            {
                Console.WriteLine("Det är minus grader");
                
            }
            else if (Temprature <= 30)
            {
                Console.WriteLine("Det är normal tempratur");

            }
            else
            {
                Console.WriteLine("Det är flr varmnt");

            }
    

        }
    }   

}
