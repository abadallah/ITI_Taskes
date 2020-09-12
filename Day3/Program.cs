using System;
using System.Collections.Generic;
using System.Linq;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Inter Point ");
            //Point Mypoint = new Point();

            //Console.Write("Enter the X : ");
            //Mypoint.SetterX(int.Parse(Console.ReadLine()));
            //Console.WriteLine("");

            //Console.Write("Enter the Y : ");
            //Mypoint.SetterY(int.Parse(Console.ReadLine()));
            //Console.WriteLine("");

            //Console.Write("Enter the Z : ");
            //Mypoint.SetterZ(int.Parse(Console.ReadLine()));
            //Console.WriteLine("");


            //Mypoint.Print();


            Console.ReadLine();
        }

    }
    class Point {
         int _X;
        int _Y;
        int _Z;

        public Point(int X,int Y , int Z )
        {

            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
      

        public int X {
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
            return ("X" + X + " Y " + Y + " Z " +Z);
        }

    }

    class Student
    {
        string  name;
        int id;

        public Student(string Name, int Id)
        {

            this.Name = Name;
            this.Id = Id;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public int Id
        {
            get { return id; }
            set { id = value; }

        }
       

        public override string ToString()
        {
            return ($"Name {Name} , ID { Id}");
        }

    }


    class Emp
    {
        string name;
        int id;

        public Emp(string Name, int Id)
        {

            this.Name = Name;
            this.Id = Id;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public int Id
        {
            get { return id; }
            set { id = value; }

        }


        public override string ToString()
        {
            return ($"Name {Name} , ID { Id}");
        }

    }


    class Rectangle
    {
        public int Dim1 { get; set; }
        public int Dim2 { get; set; }

        public Rectangle(int Dim1, int Dim2)
        {
            this.Dim1 = Dim1;
            this.Dim2 = Dim2;
        }

      

        public int Area()
        {
            return Dim2 * Dim1;
        }


    }

    class Triangle
    {
        public int Base { get; set; }
        public int Hight { get; set; }

        public Triangle(int Base, int Hight)
        {
            this.Base = Base;
            this.Hight = Hight;
        }

        public override string ToString()
        {
            return ("Hight " + Hight + " Base " + Base);
        }

        public double Area()
        {
            return 0.5 * (double)Base * Hight;
        }


    }

    class Circle
    {
        const double Bay = 3.14;
        public int Diameter { get; set; }
        public Circle(int Diameter)
        {
            this.Diameter = Diameter;
        }

        public override string ToString()
        {
            return (" Diameter " + Diameter);
        }

        public double Area()
        {
            return Diameter* Diameter * Bay;
        }


    }



}
