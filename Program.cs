using System;

namespace new1
{
    public  class classshape{
        public int Num3 { get; set; }
        public classshape(int num,int num2){
            Num3=num2*num; 
            Console.WriteLine("masahat barabar ast ba: "+Num3);
        }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("tol ra vared konid: ");
            int a=Convert.ToInt32( Console.ReadLine());
            Console.Write("arz ra vared konid: ");
            int b=Convert.ToInt32( Console.ReadLine());
            classshape cl=new classshape(a,b);
        }
    }
}
}
