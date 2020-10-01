using System;
using System.Collections.Generic;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           // Console.WriteLine(561.Rev());

            MathOp Myop = new MathOp();
           Myop.op(1,1,(a,c)=>(a+c));///+
           Myop.op(1,1,(a,c)=>(a-c));///-
           Myop.op(1,1,(a,c)=> {
               if (c == 0)
               { return 0; }
               return a / c;
           });///plus


           Myop.op(1, 5, (a, c) => (a * c));///-

           Myop.op(1, 6, delegate(int x,int y) { return x * y; });

           PerformCalculation Mydel = new PerformCalculation(Myop.Multi);
           Myop.op(1, 5, Mydel);

            var s = 0;
            var s1 = new[] { 1, 2, 3, };

            Point ds = new Point() {X=0,Y=1,Z=2 };
            var dss = new {X=0,Y=1,Z=2 };
          
            Console.ReadKey();

        }
       


    }

    public static class Ext {

        public static int Rev(this int number)
        {
            int re = 0;
            while (number != 0)
            {
                re = (re * 10) + (number % 10);
                number = number / 10;
            }
            return re;
        }
    }

    public delegate int PerformCalculation(int x, int y);
    public delegate int PerformCalculationDe();


    public class MathOp{

        public int op(int Operand1 ,int operand2, PerformCalculation mydel)
        {
            return mydel(Operand1, operand2);
        }
        public int Multi(int Op1, int Op2)
        {
            return Op1 * Op2;
        }

    }
    class Point
    {
        int _X;
        int _Y;
        int _Z;
        public Point()
        {

        }
        public Point(int X, int Y, int Z)
        {

            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }


        public int X
        {
            get { return _X; }
            set { _X = value; }

        }
        public int Y
        {
            get { return _Y; }
            set { _Y = value; }

        }
        public int Z
        {
            get { return _Z; }
            set { _Z = value; }

        }

        public void Print()
        {

            Console.WriteLine($"My Point X : {X} Y : {Y} Z : {Z} ");
        }

        public override string ToString()
        {
            return ("X" + X + " Y " + Y + " Z " + Z);
        }

    }



}
