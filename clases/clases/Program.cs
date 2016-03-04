using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    class Program
    {
        static void Main(string[] args)
        {
            EnterBithDayAndCalcAge();
        }
        private static void EnterBithDayAndCalcAge() {
            Console.WriteLine("Enter bDate (mm/dd/yyyy):");
            string bDay = Console.ReadLine();

            Console.WriteLine(string.Format("Your age is: {0}", GetAge(bDay)));

            Console.WriteLine("N - Next | Any other key to exit:");
            var cKey = Console.ReadKey();
           switch(cKey.Key){
               case ConsoleKey.N:{
                   Console.WriteLine();
                   EnterBithDayAndCalcAge();
                   break;
                }
               default:
                   break;
           }
           Console.ReadKey();
        }

        private static int GetAge(string bDay) {
            DateTime today = DateTime.Today;

            DateTime bDate = Convert.ToDateTime(bDay);

            int age = today.Year - bDate.Year;

            if (bDate.Month > today.Month) {
                return age - 1;
            }
            else if (bDate.Month < today.Month)
            {
                return age;
            }
            else {

                if (bDate.Day > today.Day) {
                    return age - 1;
                }
                else if (bDate.Day < today.Day)
                {
                    return age;
                }
                else {
                    Console.WriteLine("Happy bDay :)");
                    return age;
                }
            }
        }
    }
}
