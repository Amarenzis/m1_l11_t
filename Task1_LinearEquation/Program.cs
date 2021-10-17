using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_LinearEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Исходные
                Console.WriteLine("В данной задаче мы решаем уравнения вида k*x + b = 0 в вещественных числах.");
                Console.WriteLine("Давайте введём значение k");
                double k = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Давайте введём значение b");
                double b = Convert.ToDouble(Console.ReadLine());
                
                // Создания экземпляра структуры Linear
                Linear l1 = new Linear(k, b);
                
                //l1.bCoefficient = 2; - тест работы readonly.

                //Вызов метода Root
                double result = l1.Root();
               
                Console.WriteLine("значение x: {0:f2}", result);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(" Программу придётся закрыть. Нажмите любую кнопку.");
                Console.ReadKey();
            }
        }
        struct Linear
        {
            //Сделала readonly для небольшого теста на собственное понимание (в программе)
            public readonly double kCoefficient;
            public readonly double bCoefficient;

            public Linear(double k, double b)
            {
                kCoefficient = k;
                bCoefficient = b;
            }

            public double Root()
            {
                double root = -bCoefficient / kCoefficient;
                return root;
            }
        }
    }
}
