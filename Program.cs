using System;
using System.Collections;
using System.ComponentModel;

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
            Console.WriteLine($"\r\n~~~~~~~~~~~~~~~~~~\n");
            Console.WriteLine($"\r\n~~ Task 1 ~~");

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

            // Task 2: . Implement a program that takes a list of strings as input and performs the following operations:
            // a. Remove all elements that contain a specific character specified by the user.
            // b. Sort the remaining elements in ascending order.
            // c. Return the modified list.

            List<string> words = new List<string>();    
            words.Add("Hello");
            words.Add("World");
            words.Add("Said");
            words.Add("abc");
            Console.WriteLine($"\r\n~~~~~~~~~~~~~~~~~~\n");
            Console.WriteLine($"\r\n~~ Task 2 ~~\n");

            Console.WriteLine("The list before:");
            foreach (string item in words)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nThe list after removing the words:");
            words.RemoveAll(s => s.Contains("o"));
            words.Sort();
            foreach (string item in words)
            {
                Console.WriteLine(item);
            }

            // Task 3: Write a program that finds the maximum value in a list of integers.
            // Implement a method that accepts the list as input and returns the maximum value.


            Console.WriteLine($"\r\n~~~~~~~~~~~~~~~~~~\n");
            Console.WriteLine($"\r\n~~ Task 3 ~~\n");
            List<int> num = new List<int>();
            num.Add(10);
            num.Add(20);
            num.Add(40);
            Console.WriteLine("The Numbers list: ");
            foreach (int item in num)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\nThe maximum value is {num.Max()}");
            Console.WriteLine($"\nThe minimum value is {num.Min()}");

            // Task 4: Write a program that takes a string as an input and is a sentence.
            // It should return a string with words in reverse order.
            // Input: Hello!!! World.We are awesome.
            //Output: awesome.are We World.Hello!!!
            Console.WriteLine($"\r\n~~~~~~~~~~~~~~~~~~\n");
            Console.WriteLine($"\r\n~~ Task 4 ~~\n");
            Console.WriteLine("Enter a sentence: ");
            string sentnce = Console.ReadLine();
            char[] separators = new char[] { ' ', '.', ',', '!', '?', ';', ':' };
            string[] word = sentnce.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            List<string> wordList = new List<string>();
            wordList.AddRange(word);
            wordList.Reverse();
            word.Reverse();
            string sentnceRev = string.Join(" ", wordList);

            Console.WriteLine("The sentence with words in reverse order is:");
            Console.WriteLine(sentnceRev);

            // Task 5: Implement a program that takes a list of strings as input and checks if each string is a palindrome (reads the same forwards and backwards).
            // Return a new list containing only the palindromic strings.

            List<string> inputList = new List<string>();

            Console.WriteLine("Please enter some strings (enter 'end' to stop):");
            string input = Console.ReadLine();

            // Loop until the user enter 'end'
            while (input != "end")
            {
                // To add the input to the list
                inputList.Add(input);
                input = Console.ReadLine();
            }
            List<string> outputList = new List<string>();

            foreach (string s in inputList)
            {
                char[] chars = s.ToCharArray();

                Array.Reverse(chars);

                string reversed = new string(chars); // Convert the reversed array back to a string

                if (s.SequenceEqual(reversed))
                {
                    outputList.Add(s); // Add the string to the output list

                }
            }
            Console.WriteLine("The following strings are palindromes:");
            foreach (string p in outputList)
            {
                Console.WriteLine(p);
            }
        }


    }
}