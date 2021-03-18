using System;
using System.IO;
using System.Collections.Generic;  
using System.Linq;

namespace computershare
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("    ");

            // reads the first dataset as a single string which can be deserialized
            string dataSet1 = System.IO.File.ReadAllText(@"ChallengeSampleDataSet1.txt");
            // System.Console.WriteLine("ChallengeSampleDataSet1 values= {0}", dataSet1);

            Console.WriteLine("    ");

            // reads the second dataset as a single string which can be deserialized
            string dataSet2 = System.IO.File.ReadAllText(@"ChallengeSampleDataSet2.txt");
            // System.Console.WriteLine("ChallengeSampleDataSet2 values= {0}", dataSet2);

            // convert dataSet1 string to a list of float values and send each value to the console
            List<float> dataSet1asList = dataSet1.Split(',').Select(float.Parse).ToList();
            dataSet1asList.ForEach(Console.WriteLine);

            Console.WriteLine("  ----- THIS IS THE END OF DATASET 1 -----  ");

            // convert dataSet1 string to a list of float values and send each value to the console
            List<float> dataSet2asList = dataSet2.Split(',').Select(float.Parse).ToList();
            dataSet2asList.ForEach(Console.WriteLine);

            Console.WriteLine("  ----- THIS IS THE END OF DATASET 2 -----  ");

            // access the first element in the list
            float testvalue1 = 30;
            float testvaluefinal = testvalue1 + dataSet2asList[0];

            Console.WriteLine(testvaluefinal);

            Console.WriteLine(dataSet2asList[0]);



        }
    }
}
