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
        }
    }
}