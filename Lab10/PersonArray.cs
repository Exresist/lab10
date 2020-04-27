using System;
using System.Collections;

namespace Lab10
{
    public class PersonArray
    {
        public Person[] Arr;
        public int Count;

        // Конструктор класса без параметров
        public PersonArray()
        {
            Arr = null;
            Count = 0;
        }

        // Конструктор класса с параметрами
        public PersonArray(int size)
        {
            Arr = new Person[size];
            Count = size;
        }

        // Индексация к элементу масива 
        public Person this[int index]
        {
            get => Arr[index];
            set => Arr[index] = value;
        }

        // Ввод размера массива
        public static int InputSize()
        {
            int number;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите рамер массива:");
            Console.ForegroundColor = ConsoleColor.White;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка. Вы неверно ввели размер массива. Повторите ввод.");
                Console.ForegroundColor = ConsoleColor.White;
            }

            return number;
        }

        // Вывод всей инфорамции о персонах, информация о которых хранится в PersonArray
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Персоны:\n");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Count; i++)
            {
                this[i].Show();
                Console.WriteLine();
            }
        }

        public void Sort()
        {
            Array.Sort(Arr, new SortByAge());
        }

        public int Search(int age)
        {
            try
            {
                return Array.BinarySearch(Arr, age, new SortByAge());
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int Search(string name)
        {
            try
            {
                return Array.BinarySearch(Arr, name, new SortByName());
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public void RandomGeneration(int size)
        {
            Random random = new Random();
            Person[] people = new Person[size];
            for (int i = 0; i < size; i++)
            {
                people[i] = random.Next(1, 3) switch
                {
                    1 => new Administration(),
                    2 => new Engineer(),
                    3 => new Worker(),
                    _ => people[i]
                };
            }

            Arr = people;
            Count = size;
        }
    }
}