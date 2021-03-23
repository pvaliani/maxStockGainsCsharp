using System;
using System.IO;
using System.Collections.Generic;  
using System.Collections;
using System.Linq;
using computershare.classes;


namespace computershare
{
    class Program
    {
        static void Main(string[] args)
        {

            DataSet month1 = new DataSet("ChallengeSampleDataSet1.txt");
            List<Stock> stocks = month1.getDataSetStocks();
            List<Stock> sortedStocks = stocks.OrderBy(o=>o.getPrice()).ToList();

            // foreach (Stock i in stocks)
            // {
            //     Console.WriteLine(i.getDay());
            //     Console.WriteLine(i.getPrice());
                
            // }

            Console.WriteLine(sortedStocks);

             foreach (Stock i in sortedStocks)
            {
                Console.WriteLine(i.getDay());
                Console.WriteLine(i.getPrice());
                
            }
    


        }
    }
}
