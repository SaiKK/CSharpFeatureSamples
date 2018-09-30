using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7_0_Features
{
    public class PatternMatching
    {
        public void PatternMatchingWithConstants()
        {
            int age = 50;

            if(age is 50)
            {
                //Do write some logic here
            }
        }
        public void PatternMatchingWithType()
        {
            object age = 50;

            if (age is int myage)
            {
               
                //Do write some logic here
            }

            if (age is int)
            {
                //int myage = (int)age;

                //Do write some logic here
            }
        }
    }

    public class Animal
    {
        public string Name { get; set; }
    }

    public class Dog: Animal
    {

    }
    public class Cat : Animal
    {

    }

    public class Main
    {
        public void GetAnimal()
        {
            Dog dog = new Dog();

            if(dog is Animal animal && animal.Name == "Dog")
            {
                //Do write some logic here
            }
        }

        public void GetAnimalWithVar()
        {
            Dog dog = new Dog() { Name="Dog" };
            Cat cat = new Cat() { Name = "Cat"};

            PrintAnimalName(dog);
            PrintAnimalName(cat);

            //Local functions in C# 7.0
            void PrintAnimalName(Animal obj)
            {
                if (obj is var animal) //Always returns true
                {
                    Console.WriteLine(animal.Name);
                }
                
            }
        }
    }
      

}
