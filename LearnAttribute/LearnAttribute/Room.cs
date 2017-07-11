using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using LearnAttribute.Attributes;

namespace LearnAttribute
{
    class Room
    {

        private IAnimal _animal;

        public Room()
        {

        }

        public void For(IAnimal animal)
        {
            _animal = animal;
        }

        public void PrintWhoIsLeavingInTheRoom()
        {
            // print attributes 
            PrintAttribute(_animal.GetType());

            string name = _animal.GetAnimalName();
            Console.WriteLine(name + " is Leaving in the room");
        }

        private void PrintAttribute(System.Type t)
        {
            Console.WriteLine("Author information for {0}", t);

            var attribute = t.GetTypeInfo().GetCustomAttribute<AuthorAttribute>();

            MethodInfo[]  methodInfo =  t.GetMethods();

            foreach (var methods in methodInfo)
            {
                Console.WriteLine(methods + " : " );
                var methodattrib = methods.CustomAttributes;
                foreach (var attr in methodattrib)
                {
                    foreach(var cad in attr.NamedArguments)
                    {
                        Console.WriteLine(cad.TypedValue);
                    }
                    //Console.WriteLine(((AuthorAttribute)attr).GetAuthorName());
                }
            }

            var attributeMethod = t.GetMethod("WhatIsTheNameOfTheDog").GetCustomAttribute<AuthorAttribute>();

            Console.WriteLine(attribute.GetAuthorName());
            Console.WriteLine("The method \"WhatIsTheNameOfTheDog\" is written by " + attributeMethod.GetAuthorName());
            
        }

    }
}
