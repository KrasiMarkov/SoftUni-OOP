using System;
using System.Linq;

namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split().ToArray();

            string fullName = $"{text[0]} {text[1]}";

            string secondElement = text[2];

            string town = $"{text[3]} {text[4]}";

            MyTupleTwo<string, string, string> myTuple = new MyTupleTwo<string, string, string>(fullName, text[2], town);
            Console.WriteLine(myTuple);

            string[] myArr = Console.ReadLine().Split().ToArray();

            MyTupleTwo<string, int, string> myTuple1 = new MyTupleTwo<string, int, string>(myArr[0], int.Parse(myArr[1]), myArr[2]);
            Console.WriteLine(myTuple1);


            string[] myArrFinal = Console.ReadLine().Split().ToArray();

            MyTupleTwo<string, double, string> myTuple2 = new MyTupleTwo<string, double, string>(myArrFinal[0], double.Parse(myArrFinal[1]), myArrFinal[2]);

            Console.WriteLine(myTuple2);
        }
    }
    
}
