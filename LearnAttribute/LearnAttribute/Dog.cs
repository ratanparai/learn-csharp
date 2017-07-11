using System;
using System.Collections.Generic;
using System.Text;
using LearnAttribute.Attributes;

namespace LearnAttribute
{
    [Author("Ratan", version = 1.0)]
    class Dog : IAnimal
    {
        private readonly string _name;

        [Author("Ratan Sunder Parai", version = 1.0)]
        public Dog(string name)
        {
            _name = name;
        }

        [Author("Ratan Sunder Parai", version = 1.0)]
        public string GetAnimalName()
        {
            return this._name;
        }

        [Author("Shampad", version = 2.0)]
        public void Run()
        {
            Console.WriteLine("The Dog is runnning");
        }

        [Author("Ratan Sunder Parai", version = 1.1)]
        public string WhatIsTheNameOfTheDog()
        {
            return _name;
        }
    }
}
