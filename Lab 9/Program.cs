using System;

namespace Lab_9
{
    class Program
    {
        public Triangle Triangle
        {
            get => default;
            set
            {
            }
        }

        public TriangleArray TriangleArray
        {
            get => default;
            set
            {
            }
        }

        // Функция ввода номера части лабораторной работы
        private static int InputMode(string text, int count)
        {
            int number;
            Console.WriteLine(text);
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number > count)
            {
                Console.WriteLine("Ошибка. Вы неверно ввели часть лабораторной работы");
            }

            return number;
        }

        static void Main(string[] args)
        {
            TriangleArray triangleArray = null;
            Triangle triangle = null;

            int mode = InputMode("Введите часть (1-3) лабораторной работы (0 - выход из программы):", 3);
            while (mode != 0)
            {
                switch (mode)
                {
                    case 1:
                        {
                            Console.WriteLine("Меню");
                            int type = InputMode("1.Создать треугольник\n2.Напечать информацию об треугольнике\n3.Вычислить площадь треугольника\n0.Выход в главное меню", 3);
                            while (type != 0)
                            {
                                switch (type)
                                {
                                    case 1:
                                        {
                                            triangle = new Triangle();
                                            triangle.Create();
                                            Console.WriteLine("Треугольник создан");
                                        }
                                        break;
                                    case 2:
                                        {
                                            if (triangle != null)
                                            {
                                                triangle.Show();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Ошибка! Треугольник не создан, печать его информации невозможна");
                                            }
                                        }
                                        break;
                                    case 3:
                                        {
                                            if (triangle != null)
                                            {
                                                Console.WriteLine($"Площадь треугольника со сторонами {triangle.A}, {triangle.B}, {triangle.C} равна {triangle.Square()}");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Ошибка! Треугольник не создан, найти его площадь невозможно");
                                            }
                                        }
                                        break;
                                }
                                Console.WriteLine("Меню");
                                type = InputMode("1.Создать треугольник\n2.Напечать информацию об треугольнике\n3.Вычислить площадь треугольника\n0.Выход в главное меню", 3);
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Меню");
                            int type = InputMode("1. Cоздать треугольник\n2. Напечать информацию об треугольнике\n3. Вычислить площадь треугольника\n4. Увеличить стороны треугольника на 1\n" +
                                "5. Уменьшить стороны треугольника на 1\n6. Явное преобразовние\n7. Неявное преобразование\n8. Сравнение\n0. Выход в главное меню", 8);
                            while (type != 0)
                            {
                                switch (type)
                                {
                                    case 1:
                                        {
                                            triangle.Create();
                                            Console.WriteLine("Треугольник создан");
                                        }
                                        break;
                                    case 2:
                                        {
                                            if (triangle != null)
                                            {
                                                triangle.Show();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Ошибка! Треугольник не создан, печать его информации невозможна");
                                            }
                                        }
                                        break;
                                    case 3:
                                        {
                                            if (triangle != null)
                                            {
                                                Console.WriteLine($"Площадь треугольника со сторонами {triangle.A}, {triangle.B}, {triangle.C} равна {triangle.Square()}");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Ошибка! Треугольник не создан, найти его площадь невозможно");
                                            }
                                        }
                                        break;
                                    case 4:
                                        {
                                            if (triangle != null)
                                            {
                                                triangle++;
                                                Console.WriteLine($"Стороны треугольнка увеличины на 1");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Ошибка! Треугольник не создан, увеличить стороны невозможно");
                                            }
                                        }
                                        break;
                                    case 5:
                                        {
                                            if (triangle != null)
                                            {
                                                triangle--;
                                                Console.WriteLine($"Стороны треугольнка уменьшины на 1");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Ошибка! Треугольник не создан, уменьшить стороны невозможно");
                                            }
                                        }
                                        break;
                                    case 6:
                                        {
                                            double square = (double)triangle;
                                            Console.WriteLine($"Результат явного преобразовния (площадь треугольника): {square}");
                                        }
                                        break;
                                    case 7:
                                        {
                                            bool existance = triangle;
                                            Console.WriteLine($"Результат неявного преобразовния (существует треугольник): {existance}");
                                        }
                                        break;
                                    case 8:
                                        {
                                            if (triangle != null)
                                            {
                                                Triangle triangle1 = new Triangle(3, 4, 5);
                                                bool square = triangle >= triangle1;
                                                Console.WriteLine($"Треугольник 1 со сторонами {triangle.A}, {triangle.B}, {triangle.C} больше или равен " +
                                                    $"треугольника 2 со стронами {triangle1.A}, {triangle1.B}, {triangle1.C}: {square}");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Ошибка! Треугольник не создан,сравнить с другим треугольником его невозможно");
                                            }
                                        }
                                        break;
                                }
                                Console.WriteLine("Меню");
                                type = InputMode("1. Cоздать треугольник\n2. Напечать информацию об треугольнике\n3. Вычислить площадь треугольника\n4. Увеличить стороны треугольника на 1\n" +
                                "5. Уменьшить стороны треугольника на 1\n6. Явное преобразовние\n7. Неявное преобразование\n8. Сравнение\n0. Выход в главное меню", 8);
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Меню");
                            int type = InputMode("1. Создать массив треугольников\n2. Напечать информацию об массиве мастреугольникоа\n" +
                                "3. Кол-во созданных треугольников\n4. Номер элемента с минимальной площадью\n0.Выход в главное меню", 4);

                            while(type != 0)
                            {
                                switch (type)
                                {
                                    case 1:
                                        {
                                            int size = TriangleArray.InputSize();
                                            int typecreate = InputMode("1. Ручной ввод\n2. Случайная генерация.", 2);
                                            switch (typecreate)
                                            {
                                                case 1:
                                                    {
                                                        triangleArray = new TriangleArray(size, "keyboard");
                                                    }
                                                    break;
                                                case 2:
                                                    {
                                                        triangleArray = new TriangleArray(size);
                                                    }
                                                    break;
                                            }
                                            Console.WriteLine("Массив треугольников создан");
                                        }
                                        break;
                                    case 2:
                                        {
                                            if (triangleArray != null)
                                            {
                                                triangleArray.Show();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Ошибка! Массив треугольников не создан, его печать невозможна.");
                                            }
                                        }
                                        break;
                                    case 3:
                                        {
                                            if (triangleArray != null)
                                            {
                                                Console.WriteLine($"Кол-во созданных элементов: {triangleArray.size}");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Ошибка! Массив треугольников не создан, невозможно узнать кол-во элементов.");
                                            }
                                        }
                                        break;
                                    case 4:
                                        {
                                            if (triangleArray != null)
                                            {
                                                Console.WriteLine($"Номер элемента с минимальной площадью: {triangleArray.MinimumSquareIndex()}");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Ошибка! Массив треугольников не создан, невозможно узнать номер элемента с минимальной площадью.");
                                            }
                                        }
                                        break;
                                }
                                Console.WriteLine("Меню");
                                type = InputMode("1. Создать массив треугольников\n2. Напечать информацию об массиве мастреугольникоа\n" +
                                    "3. Кол-во созданных треугольников\n4. Номер элемента с минимальной площадью\n0.Выход в главное меню", 4);
                            }
                        }
                        break;
                }
                mode = InputMode("Введите часть (1-3) лабораторной работы (0 - выход из программы):", 3);
            }
        }
    }
}
