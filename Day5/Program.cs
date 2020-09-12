using System;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape Rec = new Rectangle(2,2);
            //Console.WriteLine(Rec.ToString()); 
            //Console.WriteLine(" Rec Area Is : "+Rec.Area());

            //Shape Tri = new Triangle(2,2);
            //Console.WriteLine(Tri.ToString()); 
            //Console.WriteLine(" Tri Area Is : " + Tri.Area());


            //Shape Cri = new Circle(2);
            //Console.WriteLine(Cri.ToString());
            //Console.WriteLine(" Cri Area Is : " + Cri.Area());

            TypeA [] s = new TypeA [] {
            new TypeB(2,1,3,4),//sum A,B
            new TypeC(3,1,5,8), //sum A,B,C,D
            };
            int sum = 0;
            foreach (var item in s)
            {
               sum+= item.Sum();

            }
            Console.WriteLine(sum);

            Console.ReadLine();

        }
    }
}


class Shape
{

    public Shape()
    {

    }
    public Shape(int Dim1, int Dim2)
    {
        this.Dim1 = Dim1;
        this.Dim2 = Dim2;

    }
    public Shape(int Dim1)
    {
        this.Dim1 = Dim1;

    }
    public int Dim1 { get; set; }
    public int Dim2 { get; set; }


   

    public virtual double Area()
    {

        return 0;
    }




}

class Rectangle : Shape
{
    public Rectangle(int Dim1,int Dim2):base(Dim1,Dim2)
    {

    }
    public override double Area()
    {
        return Dim2 * Dim1;
    }

    public override string ToString()
    {
        return "this shape is Rectangle with : Dim 1 " + Dim1 + " Dim 2 " + Dim2;
    }

}

class Triangle : Shape
{
    public Triangle(int Dim1, int Dim2) : base(Dim1, Dim2)
    {

    }
    public override string ToString()
    {
        return ("This Shape is Triangle with : Hight " + Dim1 + "and Base " + Dim2);
    }

    public override double  Area()
    {
        return 0.5 * Dim1 * Dim2;
    }


}

class Circle :Shape
{
    public Circle(int Dim1) : base(Dim1)
    {

    }
    const double Bay = 3.14;
    public override string ToString()
    {
        return (" Diameter " + Dim1);
    }

    public override double Area()
    {
        return Dim1 * Dim1 * Bay;
    }


}


class TypeA {

    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }
    public int D { get; set; }
    public TypeA(int A, int B, int C,int D)
    {
        this.A = A;
        this.B = B;
        this.C = C;
        this.D = D;
        Console.WriteLine("Type A" + A);

    }
    public TypeA()
    {

    }
    public virtual int Sum()
    {
        return 0;
    
    }
}

class TypeB :TypeA {

    public TypeB(int A, int B, int C, int D) : base(A,B,C,D )
    {
       
    }
    public TypeB(int A, int B):base(A,B,0,0)
    {
      //  this.A = A + 10;
        Console.WriteLine("Type B" + this.A);

    }
    public TypeB()
    {

    }
    public override int Sum()
    {
        return A+B;

    }
}

class TypeC : TypeB {
    public TypeC(int A, int B, int C, int D) : base(A, B, C, D)
    {

    }
    public TypeC(int A, int B) : base(A, B)
    {
     //   this.A = this.A + 10;
        Console.WriteLine("Type c" + this.A);

    }
    public TypeC()
    {

    }
    public override int Sum()
    {
        return A + B + C + D;

    }
}