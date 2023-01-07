using System;
using System.Linq;
using System.Collections.Generic;
namespace Tuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Tuple<string, int, string> myFirstTuple = new Tuple<string, int, string>("krasi", 28, "markov");

            //Console.WriteLine(myFirstTuple.Item3);

            string[] text = Console.ReadLine().Split().ToArray();

            string fullName = $"{text[0]} {text[1]}";

            MyTuple<string, string> myTuple = new MyTuple<string, string>(fullName, text[2]);
            Console.WriteLine(myTuple);

            string[] myArr = Console.ReadLine().Split().ToArray();

            MyTuple<string, int> myTuple1 = new MyTuple<string, int>(myArr[0], int.Parse(myArr[1]));
            Console.WriteLine(myTuple1);


            string[] myArrFinal = Console.ReadLine().Split().ToArray();

            MyTuple<int, double> myTuple2 = new MyTuple<int, double>(int.Parse(myArrFinal[0]), double.Parse(myArrFinal[1]));

            Console.WriteLine(myTuple2);
        }
    }
}
