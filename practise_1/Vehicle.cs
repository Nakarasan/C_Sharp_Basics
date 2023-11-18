using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise_1
{
    internal class Vehicle
    {
        // return year as a string
        public void OutputFormatedDate()
        {
            DateTime theDate = DateTime.Now;
            Console.WriteLine(theDate.ToString("yyyy/MM/dd"));
            if (theDate.Day == 25 && theDate.Month == 12)
            {
                string msg = "It's Christmas Day..";
                Console.WriteLine(msg);
                //return used for break the function.
                return;
            }
            Console.WriteLine("It's a Normal Day..");
        }

        //for return integer year
        public int FormatYear()
        {
            DateTime date = DateTime.Now;
            int year = date.Year;

            return year;
        }

        

    }
}
