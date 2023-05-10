using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, R;

            Console.WriteLine("digite o peso:");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a altura:");
            altura = double.Parse(Console.ReadLine());

            R = (peso / altura);

            if (R < 20)

                Console.WriteLine(" {0} abaixo do peso.", R);
            else
                if (R >= 20 && R < 25)

                Console.WriteLine("{0} peso ideal.", R);
            else
                if (R >= 25)
                Console.WriteLine("{0} acima do peso.", R);

        }
    }
}
