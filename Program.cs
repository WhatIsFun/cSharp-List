using System;
using System.Collections;

namespace cSharp_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List:
            List<int> list = new List<int>();
            list.Add (1);
            Console.WriteLine($"Size of the list is: {list.Count}");
            list.Add (2);
            Console.WriteLine($"Size of the list is: {list.Count}");
            list.Remove(1);
            Console.WriteLine($"Size of the list is: {list.Count}");
            list.Insert (0, 5);
            Console.WriteLine($"Size of the list is: {list.Count}");

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            List <Person> personList = new List<Person>();
            personList.Add(new Person(12399, "Mohd", "Male", 32));
            personList.Add(new Person(14569, "fda", "Female",12));
            personList.Add(new Person(23559, "ffdn", "Male",19));

            

            personList.Sort();
            Console.WriteLine("Sorting by age:");
            
            foreach (Person person in personList)
            {
                Console.WriteLine($"\r\nName: {person.Name}");
                Console.WriteLine($"Id: {person.Id}");
                Console.WriteLine($"Age: {person.Age}");
                Console.WriteLine($"Gender: {person.Gender}");
                Console.WriteLine($"\r\n~~~~~~~~~~~~~~~~~~");
            }



            List<int> numberList = new List<int>();
            numberList.Add(2);
            numberList.Add(4);
            numberList.Add(6);
            numberList.Add(15);
            numberList.Add(9);

            numberList.Sort();
            Console.WriteLine("\r\nAfter Sorting...");
            foreach (int i in numberList)
            {
                Console.WriteLine(i);
            }

            // ArrayList:
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(new Person(1101, "abc", "Male", 21));
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }

            // Task 1: Write a program that takes a list of integers as input and removes duplicate numbers, keeping only the unique elements.
            // Implement a method that accepts the list and returns a new list containing only the unique elements in the original order.
            List<int> intWithDuplicate = new List<int>();
            intWithDuplicate.Add(1);
            intWithDuplicate.Add(3);
            intWithDuplicate.Add(1);
            intWithDuplicate.Add(3);
            Console.WriteLine("The list before removing the duplicates:");
            foreach (int item in intWithDuplicate)
            {
                Console.WriteLine(item);
            }

            List<int> uniqueInt = intWithDuplicate.Distinct().ToList();

            Console.WriteLine("The list after removing the duplicates:");

            foreach (int item in uniqueInt)
            {
                Console.WriteLine(item);
            }




        }


    }
}