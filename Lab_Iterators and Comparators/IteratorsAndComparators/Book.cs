using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {

        public Book(string title, int year, params string[] authors)
        {

            this.Title = title;
            this.Year = year;
            this.Authors = authors;
        }
        public string Title { get; set; }

        public int Year { get; set; }

        public IReadOnlyList<string> Authors { get; private set; }

        public int CompareTo(Book other)
        {
            var yearComparison = this.Year.CompareTo(other.Year);

            if (yearComparison == 0)
            {
                return this.Title.CompareTo(other.Title);
            }

            return yearComparison;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
