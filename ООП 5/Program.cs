using System;

namespace ООП_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee tom = new Employee("Андрей", 22, "Apple");
        }
        class Person
        {
            string name;
            int age;

            public Person(string name)
            {
                this.name = name;
                Console.WriteLine(this.name);
            }
            public Person(string name, int age) : this(name)
            {
                this.age = age;
                Console.WriteLine(this.age);
            }
        }
        class Employee : Person
        {
            string company;

            public Employee(string name, int age, string company) : base(name, age)
            {
                this.company = company;
                Console.WriteLine(name + " " +age + " года " + company);
            }
        }
    }
}
