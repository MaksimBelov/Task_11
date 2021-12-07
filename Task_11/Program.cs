using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа находит корень уравнения 0 = kx + b");
            Console.WriteLine("Коэффициенты уравнения k, b задаются действительными числами");
            Console.WriteLine();

            double k = 0;
            double b = 0;
            bool er;

            do
            {
                try
                {
                    Console.Write("Введите значение коэффициента k = ");
                    double k1 = Convert.ToDouble(Console.ReadLine());
                    er = false;
                    k = k1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                    er = true;
                }
            }
            while (er != false);
            Console.WriteLine();

            do
            {
                try
                {
                    Console.Write("Введите значение коэффициента b = ");
                    double b1 = Convert.ToDouble(Console.ReadLine());
                    er = false;
                    b = b1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                    er = true;
                }
            }
            while (er != false);
            Console.WriteLine();

            Equation equation = new Equation (k, b);
            equation.Root();
            Console.ReadKey();
        }
    }
    struct Equation
    {
        public double k { get; set; }
        public double b { get; set; }

        public Equation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public void Root()
        {
            if (k == 0 && b == 0)
            {
                Console.WriteLine("Уравнение имеет бесконечное количество решений");
            }
            else
            {
                if (k == 0)
                {
                    Console.WriteLine("Уравнение не имеет решения");
                }
                else
                {
                    double x = -b / k;
                    Console.WriteLine("Корень уравнения x = {0}", x);
                }

            }
        }
    }

}
