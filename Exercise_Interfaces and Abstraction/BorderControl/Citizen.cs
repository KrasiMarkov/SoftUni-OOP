using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IIdentificable, IBirthable, IBuyer
    {
        private int food;
        public Citizen(int age, string id, string birthdate)
        {
           
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Name { get;  set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public string Birthdate { get; private set; }

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
            this.food += 10;
        }
    }
}
