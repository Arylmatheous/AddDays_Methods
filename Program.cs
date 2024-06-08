using System;

namespace AddDays_Method_Salandanan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 to 7: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            string dayNum = day(dayNumber);
            Console.WriteLine(dayNum);

            Console.Write("Input number to add to the day: ");
            int dayToAdd = Convert.ToInt32(Console.ReadLine());

            int sum = addition(dayNumber, dayToAdd);

            string final = finalDay(sum);
            Console.WriteLine(final);
        }

        public static string day(int dayNumber)
        {
            string dayNum = "";
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("The day is MONDAY");
                    break;
                case 2:
                    Console.WriteLine("The day is TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("The day is WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("The day is THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("The day is FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("The day is SATURDAY");
                    break;
                case 7:
                    Console.WriteLine("The day is SUNDAY");
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
            return dayNum;
        }

        public static int addition(int dayNumber, int dayToAdd)
        {
            int sum = (dayNumber + dayToAdd) - 7;

            return sum;
        }

        public static string finalDay(int sum)
        {
            string final = "";
            switch (sum)
            {
                case 1:
                    Console.WriteLine("The day is MONDAY");
                    break;
                case 2:
                    Console.WriteLine("The day is TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("The day is WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("The day is THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("The day is FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("The day is SATURDAY");
                    break;
                case 7:
                    Console.WriteLine("The day is SUNDAY");
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }

            return final;
        }
    }
}
