using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_0_Features.Switch
{
    public class Animal
    {
        public string Name { get; set; }
    }
    public class Dog : Animal
    {

    }
    public class Cat : Animal
    {

    }

    public class SwitchStatements
    {
        public void SwitchDemo()
        {
            object obj = new Dog() { Name = "Dog" };

            switch(obj)
            {
                case Dog dog: Console.WriteLine(dog.Name); break;
                case Cat cat: Console.WriteLine(cat.Name); break;
                case null: Console.WriteLine("Not Assign"); break;
                default: Console.WriteLine("No match found"); break;
            }
        }

        public void SwitchDemoWithCondition()
        {
            object obj = new Dog() { Name = "Dog" };

            switch (obj)
            {
                case Dog dog when dog.Name == "Dog": Console.WriteLine(dog.Name); break;
                case Dog dog when dog.Name == "Doggy": Console.WriteLine(dog.Name); break;
                case Cat cat: Console.WriteLine(cat.Name); break;
                case null: Console.WriteLine("Not Assign"); break;
                default: Console.WriteLine("No match found"); break;
            }
        }
    }
}
