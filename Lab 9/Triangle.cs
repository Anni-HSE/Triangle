using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9
{
    // Класс треугольник
    public class Triangle
    {
        protected double a; // Первая сторона
        protected double b; // Вторая сторона
        protected double c; // Третья сторона

        public static int count = 0; // счетчик созданных объектов

        public double A
        {
            get { return a; }
            set
            {
                try
                {
                    if (value < 0)
                        throw new ArgumentException("Ошибка, введите положительную длину 1 cтороны треугольника!");
                    else
                        a = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                try
                {
                    if (value < 0)
                        throw new ArgumentException("Ошибка, введите положительную длину 2 cтороны треугольника!");
                    else
                        b = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public double C
        {
            get { return c; }
            set
            {
                try
                {
                    if (value < 0)
                        throw new ArgumentException("Ошибка, введите положительную длину 3 cтороны треугольника!");
                    else
                        c = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        // конструктор без параметров
        public Triangle()
        {
            a = 0; b = 0; c = 0;
            count++;
        }

        // конструктор с пераметрами
        public Triangle(double _a, double _b, double _c)
        {
            // вызов внутреннего метода класса из конструктора
            if (Triangle.Existence(_a, _b, _c))
            {
                a = _a;
                b = _b;
                c = _c;
                count++;
            }
            else
            {
                new Triangle();
            }
        }

        // метод класса, определяющий можно ли по данным a, b, c построить треугольник
        public bool Existence()
        {
            if (a < 0 && b < 0 && c < 0) return false;
            if (a >= (b + c)) return false;
            if (b >= (a + c)) return false;
            if (c >= (a + b)) return false;
            return true;
        }

        // статическая функция класса, определяющая можно ли по данным a, b, c построить треугольник
        public static bool Existence(double _a, double _b, double _c)
        {
            if (_a < 0 && _b < 0 && _c < 0) return false;
            if (_a >= (_b + _c)) return false;
            if (_b >= (_a + _c)) return false;
            if (_c >= (_a + _b)) return false;
            return true;
        }

        // метод класса, определяющий периметр треугольника
        public double Perimetr()
        {
            // вызов внутреннего метода из метода Perimetr(), проверка
            if (Existence())
            {
                return a + b + c;
            }
            else
            {
                return 0.0;
            }
        }

        // статическая функция класса, определяющая периметр треугольника
        public static double Perimetr(Triangle triangle)
        {
            // вызов внутреннего метода из метода Perimetr(), проверка
            if (triangle.Existence())
            {
                return triangle.a + triangle.b + triangle.c;
            }
            else
            {
                return 0.0;
            }
        }

        // метод класса, определяющий площадь треугольника
        public double Square()
        {
            // вызов внутреннего метода из метода Square(), проверка
            if (Existence())
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
                return 0.0; 
        }

        // статическая функция класса, определяющ площадь треугольника
        public static double Square(Triangle triangle)
        {
            if (triangle.Existence())
            {
                double p = (triangle.a + triangle.b + triangle.c) / 2;
                return Math.Sqrt(p * (p - triangle.a) * (p - triangle.b) * (p - triangle.c));
            }
            else
                return 0.0;
        }

        // метод класса, выводящий информацию об объекте
        public void Show()
        {
            Console.WriteLine($"Треуголник со сторонами {a}, {b}, {c} c площадью {Square()} квадратных едениц");
            Console.WriteLine("Счетчик созданных объектов: " + Triangle.Quantity());
        }

        // метод класса, выводящий создающий информацию об объекте
        public void Create()
        { 

            Console.Write("Enter first kathetus of triangle:");
            A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second kathetus of triangle:");
            B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third kathetus of triangle:");
            C = Convert.ToDouble(Console.ReadLine());
          
        }

        // унарная операция, увеличивающеая координаты стороны треугольника на 1
        public static Triangle operator ++ (Triangle tr1)
        {
            tr1.a += 1.0; tr1.b += 1.0; tr1.c += 1.0;
            return tr1;
        }

        // унарная операция, увеличивающая координаты стороны треугольника на 1
        public static Triangle operator -- (Triangle tr1)
        {
            tr1.A -= 1.0; tr1.B -= 1.0; tr1.C -= 1.0;
            if (tr1.A > 0 && tr1.A > 0 && tr1.A > 0 && tr1.Existence())
                return tr1;
            else
                return new Triangle();
        }

        // бинарная операция, сравнивающая площадь двух треугольников
        public static bool operator <= (Triangle tr1, Triangle tr2)
        {
            return tr1.Square() <= tr2.Square();
        }

        // бинарная операция, сравнивающая площадь двух треугольников
        public static bool operator >= (Triangle tr1, Triangle tr2)
        {
            return tr1.Square() >= tr2.Square();
        }

        // операция явного приведения типа double: "Если треугольник существует, то присвоить площадь треугольника, иначе -1"
        public static explicit operator double (Triangle tr1)
        {
            if (tr1.Existence())
            {
                return tr1.Square();
            }
            else
                return -1;
        }

        // операция неявного приведения типа bool: "Если треугольник существует с такими сторонами, то true, иначе false"
        public static implicit operator bool (Triangle tr1)
        {
            if (tr1.Existence())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int Quantity()
        {
            return count;
        }
    }
}
