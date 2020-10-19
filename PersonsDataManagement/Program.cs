﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PersonsDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management Program");
            List<Person> listPersonInCity = new List<Person>();
            AddRecords(listPersonInCity);
            RetrievingTopTwoRecordForAgeLessThanSixty(listPersonInCity);
            CheckingForTeenagerPerson(listPersonInCity);
            RetrievingAverageAge(listPersonInCity);
            Console.ReadKey();
        }
        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork,NY", 15));
            listPersonInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork,NY", 25));
            listPersonInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork,NY", 35));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork,NY", 45));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork,NY", 45));
            listPersonInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton,OH", 55));
            listPersonInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456882", "Winston", "1208 Alex st, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore,NY", 85));
            listPersonInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore,NY", 95));
        }
        public static void RetrievingTopTwoRecordForAgeLessThanSixty(List<Person> listPersonsInCity)
        {
            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name :" + person.Name + "\t\tAge: " + person.Age);
            }
        }
        public static void CheckingForTeenagerPerson(List<Person> listPersonInCity)
        {
            if (listPersonInCity.Any(e => e.Age >= 13 && e.Age < 19))
            {
                Console.WriteLine("Yes, We have some teenagers in the list");
            }
            else
            {
                Console.WriteLine("No, we don't have teenagers in the list");
            }
        }
        public static void RetrievingAverageAge(List<Person> listPersonsInCity)
        {
            Console.WriteLine("Average age = "+ listPersonsInCity.Average(e => e.Age));
        }
    }
}
