using System;

namespace Library
{
    public class Person
    {
        public string Name{ get; set; }
        public double Age{ get; set; }
        public Person(string name, double age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}