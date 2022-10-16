using System;
using System.Collections.Generic;
using System.Linq;
namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList rrrrr = new RandomList();

            rrrrr.Add("gosho");
            rrrrr.Add("lqlql");
            rrrrr.Add("ggggggggg");
            rrrrr.Add("pkkkkkk");

            var result = rrrrr.RandomString();

            
        }
    }
}
