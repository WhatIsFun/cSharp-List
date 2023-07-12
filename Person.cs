using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Lists
{
    internal class Person : IComparable<Person>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public Person(int Id, string Name, string Gender, int Age) 
        { 
            this.Id = Id;
            this.Name = Name;
            this.Gender = Gender;
            this.Age = Age;
        }
        public int CompareTo(Person? other)
        {
            if (other == null) return 1;
            if (other.Age == this.Age) return 0;
            if (other.Age > this.Age) return -1;
            return 1;
        }
        public void ToString()
        {
            Console.WriteLine($"\r\nName: {Name}");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"\r\n~~~~~~~~~~~~~~~~~~");
        }

    }
}
