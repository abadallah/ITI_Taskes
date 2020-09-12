using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MaxDis
            //int[] arr = new int[] {1,2,3,1,4,5,6,8,4 };
            //int MaxDis = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int Num1 = arr[i];
            //    for (int j = i+1; j < arr.Length; j++)
            //    {
            //        if (Num1 == arr[j] &&(j-i)-1 >MaxDis)
            //        {
            //            MaxDis = (j - i) - 1;
            //            Console.WriteLine(MaxDis);
            //        }

            //    }
            //}
            //Console.WriteLine($"The Max Dis is : {MaxDis}");

            #endregion
            #region StuDegree
            //Console.Write("Enter Number Of subject : ");
            //int Num = int.Parse (Console.ReadLine());
            //Console.WriteLine("");
            //Console.WriteLine("Enter subject's Degrees ");
            //Console.WriteLine("");

            //int[] Arr = new int[Num];

            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Console.Write($"Enter subject's Degree{i} : ");
            //    Arr[i] =int.Parse( Console.ReadLine());

            //}


            //int Sum = 0;
            //foreach (var item in Arr)
            //{
            //    Console.WriteLine($"Degree is {item}");
            //    Sum += item;

            //}
            //Console.WriteLine($"Sum is {Sum}");

            #endregion

            #region MyRegiondem2
            //Console.Write("Enter Number Of student : ");
            //int StNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("");
            //Console.Write("Enter Number Of subject : ");
            //int SuNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("");

            //int[,] Arr = new int[StNum, SuNum];


            //for (int i = 0; i < Arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Arr.GetLength(1); j++)
            //    {
            //      Console.Write($"student num {i+1} Enter subject's Degree{j+1} : ");
            //      Arr[i,j] =int.Parse( Console.ReadLine());
            //    }
            //    Console.WriteLine("------------------------");

            //}

            //Console.WriteLine("------------------------");
            //Console.WriteLine("You Entered  ");
            //Console.WriteLine("");

            //for (int i = 0; i < Arr.GetLength(0); i++)
            //{
            //    int stuSum = 0;
            //    for (int j = 0; j < Arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"student num {i+1} Enter subject's Degree{j+1} : {Arr[i, j]} ");
            //        stuSum += Arr[i, j];
            //    }
            //    Console.WriteLine($"the Sum Of Student Sub is : {stuSum}");

            //    Console.WriteLine("------------------------");

            //}
            //for (int i = 0; i < Arr.GetLength(1); i++)
            //{
            //    int SubSum = 0;

            //    for (int j = 0; j < Arr.GetLength(0); j++)
            //    {
            //        SubSum += Arr[j, i];

            //    }
            //    double avrage = (double)SubSum / StNum * 100;
            //    Console.WriteLine($"sub {i+1} avrage is  {avrage}");

            //}
            #endregion

            Console.ReadLine();

        }
    }
}
