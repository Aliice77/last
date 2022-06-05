using System;

namespace new1
{
    public class classshape
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }

        public classshape(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
            Num3 = Num2 * Num1;
        }
        public virtual void masahat()
        {
            Console.WriteLine("class 1 & constructor 1: " +Num3);
        }
    }
    public class shape1 : classshape
    {
        public shape1(int num, int num2):base(num,num2)
        {
            Num3 = num2 * num;
        }
        public override void masahat()
        {
            Console.WriteLine("class 1 & constructor overloading: " + Num3);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("tol ra vared konid: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("arz ra vared konid: ");
            int b = Convert.ToInt32(Console.ReadLine());
            classshape cl = new classshape(a, b);
            cl.masahat();
            shape1 sh = new shape1(a, b);
            sh.masahat();
            Console.ReadKey();
        }
    }
}

