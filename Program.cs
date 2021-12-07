using System;

namespace Lab4._2
{
    class Program
    {
        static void Main(string[] args)
              {

                Console.WriteLine("Введите A:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите B:");
                double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите действие: \n1)+\n2)-\n3)*\n4)/");
            int vari = int.Parse(Console.ReadLine());
            switch (vari)
            {
                case 1:
                    Console.WriteLine(pls(a, b));
                    break;
                case 2:
                    Console.WriteLine(min(a, b));
                    break;
                case 3:
                    Console.WriteLine(multiply(a, b));
                    break;
                case 4:
                    Console.WriteLine(div(a, b));
                    break;
            }
        }
            static double min(double A, double B)
            {
                return A - B;
            }
                 
        static double pls(double A, double B)
        {
            return A + B;
        }

        static double div(double A, double B)
        {
            return A / B;
        }
        static double multiply(double A, double B)
        {
            return A * B;
          
        }
    }

}