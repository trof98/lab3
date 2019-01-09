using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберете пункт меню:");
            Console.WriteLine("1 - умножение");
            //Console.WriteLine("1 - умножение");
            //Console.WriteLine("2 - сложение");
            //Console.WriteLine("3 - деление");
            //Console.WriteLine("4 - вычитаение");

            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    {
                        int C = A * B;
                        Console.WriteLine("Ответ: {0}", C);

                        break;
                    }

                //case 2:
                //    {
                //        int C = A + B;
                //        Console.WriteLine("Ответ: {0}", C);

                //        break;
                //    }

                //case 3:
                //    {
                //        int C = A / B;
                //        Console.WriteLine("Ответ: {0}", C);

                //        break;
                //    }

                //case 4:
                //    {
                //        int C = A - B;
                //        Console.WriteLine("Ответ: {0}", C);

                //        break;
                //    }

            }
            Console.ReadKey();
        }

    }
}
