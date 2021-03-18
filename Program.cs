using System;
using System.IO;

namespace computershare
{
    class Program
    {
        static void Main(string[] args)
        {
    
           
            Console.WriteLine("    ");

            // reads the first dataset as a single string which can be deserialized
            string dataSet1 = System.IO.File.ReadAllText(@"ChallengeSampleDataSet1.txt");
            System.Console.WriteLine("ChallengeSampleDataSet1 values= {0}", dataSet1);

            Console.WriteLine("    ");

            // reads the second dataset as a single string which can be deserialized
            string dataSet2 = System.IO.File.ReadAllText(@"ChallengeSampleDataSet2.txt");
            System.Console.WriteLine("ChallengeSampleDataSet2 values= {0}", dataSet2);



        }
    }
}
