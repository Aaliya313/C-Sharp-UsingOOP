using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOOP
{
    abstract class Pet //base class //encapsulation, everything tied up in this class
    {
        private int iD;

        //attributes
        public int GetID()
        {
            return iD;
        }

        public void SetID(int value)
        {
            iD = value;
        }

        //attributes

        private string name;

        public string Getname()
        {
            return name;
        }

        public void Setname(string value)
        {
            name = value;
        }

        private int age;

        public int Getage()
        {
            return age;
        }

        public void Setage(int value)
        {
            age = value;
        }

        private string colour;

        public string Getcolour()
        {
            return colour;
        }

        public void Setcolour(string value)
        {
            colour = value;
        }

        //constructor
        public Pet(int iD, string name, int age, string colour)
        {
            SetID(iD);
            this.Setname(name);
            this.Setage(age);
            this.Setcolour(colour);
        }

        //3 x behaviours/methods the animal can do
        public void Sleep()
        {
            Console.WriteLine("Zzzzzzzz!");
        }

        public void Eat()
        {
            Console.WriteLine("Nom, nom nom");
        }

        public void GettingOlder()
        {
            Setage(Getage() + 1);
        }

        public abstract void Play();
    }
}
