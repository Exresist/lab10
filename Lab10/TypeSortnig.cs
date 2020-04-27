﻿using System;
 using System.Collections;
 using System.Collections.Generic;
using System.Text;

 namespace Lab10
{
    // Сортировка массива Person по имени
    public class SortByName : IComparer
    {
        int IComparer.Compare(object obj1, object obj2)
        {
            Person p1 = (Person)obj1;
            Person p2 = (Person)obj2;
            return String.Compare(p1.Name, p2.Name);
        }
    }

    // Сортировка массива Person по фамилии
    public class SortBySurname : IComparer
    {
        int IComparer.Compare(object obj1, object obj2)
        {
            Person p1 = (Person)obj1;
            Person p2 = (Person)obj2;
            return String.Compare(p1.Surname, p2.Surname);
        }
    }

    // Сортировка массива Person по полу
    public class SortByGender : IComparer
    {
        int IComparer.Compare(object obj1, object obj2)
        {
            Person p1 = (Person)obj1;
            Person p2 = (Person)obj2;
            return String.Compare(p1.Gender, p2.Gender);
        }
    }

    // Сортировка массива Person по возрасту
    public  class SortByAge : IComparer
    {
        int IComparer.Compare(object obj1, object obj2)
        {
            Person p1 = obj1 as Person;
            Person p2 = obj2 as Person;
            int p1Age = p1.Age();
            int p2Age = p2.Age();
            if (p1Age > p2Age)
                return 1;
            if (p1Age < p2Age)
                return -1;
            return 0;
        }
    }

    // Сортировка массива Person по дате рождения
    public class SortByDOB : IComparer
    {
        int IComparer.Compare(object obj1, object obj2)
        {
            Person p1 = obj1 as Person;
            Person p2 = obj2 as Person;
            if (p1.DateOfBirth.Year > p2.DateOfBirth.Year)
            {
                return 1;
            }

            if (p1.DateOfBirth.Month < p2.DateOfBirth.Month)
            {
                return 1;
            }

            if (p1.DateOfBirth.Day < p2.DateOfBirth.Day)
            {
                return 1;
            }

            return -1;
        }
    }

    // Сортировка массива Person по стажу
    public class SortByExperience : IComparer
    {
        int IComparer.Compare(object obj1, object obj2)
        {
            Person p1 = obj1 as Person;
            Person p2 = obj2 as Person;
            if (p1.Experience > p2.Experience)
                return 1;
            if (p1.Experience < p2.Experience)
                return -1;
            return 0;
        }
    }
}
