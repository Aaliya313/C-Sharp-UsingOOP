using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace UsingOOP
{
    class Dog : Pet //inheritance of base class, dog class inherits from pet class
    {
        public string breed { get; set; }
      
        public Dog(int iD, string name, int age, string colour, string breed) 
            : base(iD, name, age, colour)
        {
            this.breed = breed;
        }

        override public void Play()
        {
            Console.WriteLine("Fetch!");
        }

        public void Jump() //can create your own methods in the subclasses as well
        {
            Console.WriteLine($"{Getname()} jumps!"); //have to have brackets when calling a method
        }

    }
}
