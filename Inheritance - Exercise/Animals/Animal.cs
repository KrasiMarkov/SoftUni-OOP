using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{

    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public bool krasi = false;

        private const string ERROR_MASSAGE = "Invalid input!";
        public Animal(string name, int age, string gender)
        {
            this.Name = name;

            this.Age = age;

            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;

            }

            private set
            {

                if (String.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine(ERROR_MASSAGE);

                    
                }
                else
                {
                    this.name = value;
                }

            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value >= 0)
                {
                    this.age = value;
                }
                else
                {
                    Console.WriteLine(ERROR_MASSAGE);

                    krasi = true;

                }
            }
        }


        public string Gender
        {
            get
            {
                return this.gender;

            }

            private set
            {
                if (value != "Male" && value != "Female")
                {
                    Console.WriteLine(ERROR_MASSAGE);
                }
                else
                {
                    this.gender = value;
                }

            }
        }


        public abstract string ProduceSound();


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}");
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.AppendLine($"{this.ProduceSound()}");

            return sb.ToString().TrimEnd();
        }



    }

}

