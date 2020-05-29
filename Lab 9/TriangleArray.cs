using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9
{
    public class TriangleArray
    {
        public const int MaxSize = 100;
        public const int MaxValue = 100;
        
        public Triangle[] arr;
        public int size;
        
        // конструктор без параметров
        public TriangleArray ()
        {
            arr = null;
            size = 0;
        }

        // конструктор с пераметрами для случайного заполнения
        public TriangleArray (int _size)
        {
            Random random = new Random();
            Triangle[] arrNew = new Triangle[_size];
            for(int i=0; i < _size; i++)
            {
                double a, b, c;
                do
                {
                    a = random.Next(1, MaxValue);
                    b = random.Next(1, MaxValue);
                    c = random.Next(1, MaxValue);
                } while (!Triangle.Existence(a, b, c));
                arrNew[i] = new Triangle(a, b, c);
            }
            arr = arrNew;
            size = _size;
        }

        // конструктор с пераметрами для ручного заполнения
        public TriangleArray(int _size, object keyboard)
        {     
            Triangle[] arrNew = new Triangle[_size];            
            for(int i = 0; i < _size; i++)
            {
                double a, b, c;
                do
                {
                    a = InputNumber();
                    b = InputNumber();
                    c = InputNumber();
                } while (Triangle.Existence(a, b, c));
                arrNew[i] = new Triangle(a, b, c);
            }
            arr = arrNew;
            size = _size;
        }

        // индексатор (для доступа к элеменам массива)
        public Triangle this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }

        public Triangle Triangle
        {
            get => default;
            set
            {
            }
        }

        // функция класса, находящая номер элемента с минимальной площадью
        public int MinimumSquareIndex()
        {
            Triangle minimumTriangle = arr[0];
            int minimumIndex = 0;
            for(int i = 1; i < size; i++)
            {
                if(arr[i].Square() < minimumTriangle.Square())
                {
                    minimumIndex = i;
                    minimumTriangle = arr[i];
                }
            }
            return minimumIndex + 1;
        }

        // Функция класса, выводящая информацию о массиве
        public void Show()
        {
            Console.WriteLine("Массив треугольников");
            for(int i = 0; i < size; i++)
            {
                Console.Write($"{i + 1} ");
                arr[i].Show();
            }
        }

        // приватная функция для ручного ввода числа
        public static double InputNumber()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.WriteLine("Ошибка. Введите снова длину треугольника.");
            }
            return number;
        }

        public static int InputSize()
        {
            Console.WriteLine("Введите снова размер массива.");
            int number;
            while(!(int.TryParse(Console.ReadLine(), out number)) || number < 0 || number > 100)
            {
                Console.WriteLine("Ошибка. Введите снова размер массива.");
            }
            return number;
        }
    }
}
