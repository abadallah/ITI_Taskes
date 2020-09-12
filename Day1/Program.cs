using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Revarse

            //Console.WriteLine("Enter The numer");
            //int number = int.Parse(Console.ReadLine());

            //while (number!=0)
            //{
            //    Console.Write(number%10);
            //    number = number / 10;
            //}
            #endregion

            #region Sum
            //int sum = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"EnterNum {i}");
            //    sum += int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();

            #endregion

            #region Degree

            Console.WriteLine("Enter Degree");
            int Degree = int.Parse(Console.ReadLine());
            if (Degree >= 85)
            {
                Console.WriteLine("Exellent");
            }
            else if (Degree < 85 && Degree >= 75)
            {
                Console.WriteLine("Very good");

            }
            else if (Degree < 75 && Degree >= 65)
            {
                Console.WriteLine("good");

            }
            else
            {
                Console.WriteLine("accepted");

            }
            #endregion


            Console.ReadLine();

        }
    }
}
