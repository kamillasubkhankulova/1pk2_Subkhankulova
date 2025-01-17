using System.Data;

namespace Task_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 8;
            double b = 14;
            double c = Math.PI / 4;
            var k = Math.Pow(b + Math.Pow(a - 1, 1 / 3), 1 / 4);
            var l = Math.Abs(a - b) * Math.Pow(Math.Sin(c), 2) + Math.Tan(c);
            if (l != 0)
            {
                var m = k / l;
                Console.WriteLine(m);
            }
            else
            {
                Console.WriteLine("Ошибка: деление на ноль!");
            }





        }
    }
}
