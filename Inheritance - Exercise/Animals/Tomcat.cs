using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        private const string DEFFAULT_GENDER = "Male";

        public Tomcat(string name, int age)
            : base(name, age, DEFFAULT_GENDER)
        {

        }

        public override string ProduceSound()
        {
            return "MEOW";
        }

    }
}
