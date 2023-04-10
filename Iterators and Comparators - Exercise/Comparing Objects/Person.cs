using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;

        }
        public string Name { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }

        public int CompareTo(Person other)
        {
            var nameComparison = this.Name.CompareTo(other.Name);

            if (nameComparison == 0)
            {
                var ageComparison = this.Age.CompareTo(other.Age);

                if (ageComparison == 0)
                {
                    var townComparison = this.Town.CompareTo(other.Town);

                    if (townComparison == 0)
                    {
                        return 0;
                    }

                    return townComparison;
                }

                return ageComparison;
            }

            return nameComparison;
        }
    }
}
