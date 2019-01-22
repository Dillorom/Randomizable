using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizable
{
    interface IRandomizable
    {
        double GetRandomNum(double input);
    }

    public class MyRandomizer : IRandomizable
    {
        public MyRandomizer() { }

        public double GetRandomNum(double input)
        {
            Random random = new Random();
            double seed = random.NextDouble();
            return seed * input;
        }

    }

    class Program 
    {
        static void Main(string[] args)
        {

            MyRandomizer mr = new MyRandomizer();

            string str;
            do
            {
                Console.WriteLine("Enter the upperbound number: ");
                str = Console.ReadLine();
                try
                {
                    double input = Double.Parse(str);
                    Console.WriteLine($"Double number between 0 and {input}: " + mr.GetRandomNum(input), input);
                }
                catch (Exception e) { }
            }
            while (str != "exit");
            
            Console.ReadKey();
            
        }
    }
}
