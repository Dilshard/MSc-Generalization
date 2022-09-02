using System;

namespace Generalization
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("IIT", 1, "John", 25, "Colombo");
            Console.WriteLine(student1.getName());
            Console.WriteLine(student1.getSchool());

            //ERROR because Person is an Abstract class
            //Person person1 = new Person("Peter", 21, "Kandy"); 
            //Console.WriteLine(person1.getName());

            student1.getLocation();

            int number = 500;
            String value = number.ToString();
            Console.WriteLine(student1.ToString());

            Object obj1 = new object();
            
        }
    }
}

