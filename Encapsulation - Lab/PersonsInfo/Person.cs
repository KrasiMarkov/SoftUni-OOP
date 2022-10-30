using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string secondName;
        private int age;
        private decimal salary;


        public Person(string firstName, string secondName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get
            {
                return firstName;

            }
            set
            {
                if (ValidateName(value))
                {
                    firstName = value;
                    
                }
                else
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }

                
            }
        }








        public string SecondName
        {
            get
            {
                return secondName;

            }
            set
            {
                if (ValidateName(value))
                {
                    secondName = value;
                    
                }
                else
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");

                    
                }
                

            }
        }

        public int Age
        {
            get
            {
                return age;

            }
            set
            {
                if (value > 0)
                {
                    age = value;

                    
                }

                else
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                     
                }
                
            }
        }

        public decimal Salary
        {
            get
            {
                return salary;

            }
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");


                }

                
                
                    salary = value;
                
                

            }

        }
        private bool ValidateName(string name)
        {
            return name?.Length > 2;
                


        }
        public void IncreaseSalary(decimal percentage)
        {


            if (Age > 30)
            {
                this.Salary = this.Salary + this.Salary * percentage / 100;
            }

            else
            {
                this.Salary = this.Salary + this.Salary * percentage / 200;
            }

        } 

        public override string ToString()
        {
           

           return ($"{this.FirstName} {this.SecondName} receives {this.Salary:F2} leva.");



            
        }
    }
}
