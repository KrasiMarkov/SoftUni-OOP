using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten : Cat
    {
        private const string DEFFAULT_GENDER = "Female";
        

        public Kitten(string name, int age)
            : base(name, age, DEFFAULT_GENDER)
        {
           
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}

