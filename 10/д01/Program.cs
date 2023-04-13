using System;
namespace д01
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Miu("Введите сторону a треугольника: ");
   
            double b = Miu("Введите сторону b треугольника: ");
     
            double c = Miu("Введите сторону c треугольника: ");
      

            double a2 = Math.Pow(a, 2);
            double b2 = Math.Pow(b, 2);
            double c2 = Math.Pow(c, 2);

            if ((a * b * c != 0) && (c <= a + b ^ a <= c + b ^ b <= a + c) && (a > 0 && b > 0 && c > 0))
            {
                if (c2 > a2 + b2)
                    Console.WriteLine("Это тупоугольный треугольник.");
                if (c2 == a2 + b2)
                    Console.WriteLine("Это прямоугольный треугольник.");
                if (c2 < a2 + b2)
                    Console.WriteLine("Это остроугольный треугольник.");

                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Площадь треугольника равна:" + s);
            }

            else
            {
                if (a * b * c == 0)
                {
                    Console.WriteLine("Сторона треугольника не может быть равна 0!");
                }
                if (c > a + b || a > c + b || b > a + c)
                {
                    Console.WriteLine("С такими сторонами треугольник не может существовать!");
                }
                if (a < 0 || b < 0 || c < 0)
                {
                    Console.WriteLine("Стороны треугольника не могут быть отрицательными!");
                }
            }

        }
    
            public static int Miu(string num)
            {
                while (true)
                {
                    Console.Write(num);
                    if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
                        return number;
                    Console.WriteLine("Некорректный ввод, введите натуральное число.");
                }
            }
        }
    }


