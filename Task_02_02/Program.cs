using System.Data;
using System.Numerics;

namespace Task_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a=8;
            double b=14;
            double c=Math.PI/4;
            double result=Math.Pow(b+Math.Pow(a-1,1.0/3),0.25)/(Math.Abs(a-b)*(Math.Pow(Math.Sin(c),2)+Math.Tan(c)));         
            Console.WriteLine(result);
        
        }
    }
}
