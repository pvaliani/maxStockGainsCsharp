using System;
using System.IO;
using System.Collections.Generic;  
using System.Collections;
using System.Linq;


namespace computershare
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("    ");

            // reads the first dataset as a single string which can be deserialized
            string pricesMonth1 = System.IO.File.ReadAllText(@"ChallengeSampleDataSet1.txt");
            // System.Console.WriteLine("ChallengeSampleDataSet1 values= {0}", pricesMonth1);

            Console.WriteLine("    ");

            // reads the second dataset as a single string which can be deserialized
            string pricesMonth2 = System.IO.File.ReadAllText(@"ChallengeSampleDataSet2.txt");
            // System.Console.WriteLine("ChallengeSampleDataSet2 values= {0}", pricesMonth2);

            // convert pricesMonth1 string to a list of double values and send each value to the console
            List<double> pricesMonth1AsList = pricesMonth1.Split(',').Select(double.Parse).ToList();
            pricesMonth1AsList.ForEach(Console.WriteLine);

            Console.WriteLine("  ----- THIS IS THE END OF DATASET 1 -----  ");

            // convert pricesMonth1 string to a list of double values and send each value to the console
            List<double> pricesMonth2AsList = pricesMonth2.Split(',').Select(double.Parse).ToList();
            pricesMonth2AsList.ForEach(Console.WriteLine);

            Console.WriteLine("  ----- THIS IS THE END OF DATASET 2 -----  ");

            // access the first element in the list
            double testvalue1 = 30;
            double testvaluefinal = testvalue1 + pricesMonth2AsList[0];

            Console.WriteLine(testvaluefinal);
            Console.WriteLine(pricesMonth2AsList[0]);
            Console.WriteLine("  ----- THIS IS THE LOGIC FOR FINDING THE MAX GAINS -----  ");

            // create an empty dynamic array of arrays stockGains = [[],[],[],[],[]]

            double[,] stockGains = {};
            // Console.WriteLine(stockGains[0,0]);
        
            foreach (double currentPrice in pricesMonth1AsList){
                // divide the nextPrice by currentPrice
                double gains = ((currentPrice+1)/currentPrice);
                // append the result to stockGains
                // stockGains.Add(gains);
                // do this on repeat until the end of pricesMonth1Aslist
            } 

    
            // findMax within stockGains -----
            // findMax in each nested array
            // then backtrack to find what that price and stock was


        }
    }
}
