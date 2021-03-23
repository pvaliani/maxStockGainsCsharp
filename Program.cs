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

            DataSet month1 = new DataSet("ChallengeSampleDataSet2.txt");
            List<Stock> stocks = month1.getDataSetStocks();

            // sort the stocks by ascending price, keeping note of their index position i.e day in the month
            List<Stock> sortedStocks = stocks.OrderBy(o=>o.getPrice()).ToList();


            Console.WriteLine(sortedStocks);

             foreach (Stock i in sortedStocks)
            {
                Console.WriteLine(i.getDay());
                Console.WriteLine(i.getPrice());
                
            }

            // int index = 0;
            // foreach (var j in sortedStocks)
            // {
                if (sortedStocks[0].getDay() > sortedStocks[29].getDay()) {
                    Console.WriteLine($"{sortedStocks[0].getDay()}({sortedStocks[0].getPrice()}), {sortedStocks[29].getDay()}({sortedStocks[29].getPrice()})");

            }
            //    index++; 
            // }

            // for all the stocks in sortedStocks
            // if the current sorted stocks day is less than the last one in the sortedStocks
            // AND the current sorted stocks price is less than the last one in the sorted stocks
            // print the results 

    
           

            // the day of the buy price has to be less than the day of the sell price
            // i.e day of the buy price has to be less than sortedStocks.getDay at 30 or sortedstocks[30].getDay
            // 19.13, day 7 and day 14, 27.2 are the answers for dataset2

            
                
            

    


        }
    }
}
