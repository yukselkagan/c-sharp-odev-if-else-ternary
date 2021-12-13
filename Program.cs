using System;

namespace c_sharp_odev_if_else_ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;

            if(hour >= 6 && hour < 11)
            {
                Console.WriteLine("Good morning");
            }
            else if(hour <= 18)
            {
                Console.WriteLine("Good day");
            }
            else
            {
                Console.WriteLine("Good evening");
            }


            string resultString = (hour<12) ? "Before 12" : "After 12";
            string resultString2 = (hour>=6 && hour<11) ? "Good morning" : (hour<=18) ? "Good day" : "Good Evening";


            Console.WriteLine(resultString);
            Console.WriteLine(resultString2);




        }
    }
}
