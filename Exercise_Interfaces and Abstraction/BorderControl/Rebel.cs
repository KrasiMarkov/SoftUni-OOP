using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Rebel : IBuyer
    {
        private int food;

        public Rebel(int age, string group)
        {
           
            this.Age = age;
            this.Group = group;
            
        }

        public string Name { get; set; }

        public int Age { get; private set; }

        public string Group { get; private set; }

        public int Food
        {
            get
            {
                return this.food;
            }
            set 
            {
                this.food = value;
            }

        }

        public void BuyFood()
        {
            this.food += 5;
            
        }
    }
}
