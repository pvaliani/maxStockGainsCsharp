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

            // sort the stocks by ascending price, keeping note of their index position i.e day in the month
            List<Stock> sortedStocks = stocks.OrderBy(o=>o.getPrice()).ToList();

             foreach (Stock i in sortedStocks)
            {
                Console.WriteLine(i.getDay());
                Console.WriteLine(i.getPrice());
                
            }

            Console.WriteLine("---------------SPACE HEREEEE------------------");

            List<Stock> validStocks = new List<Stock>();

            int index = 0;
            foreach (var sortedStock in sortedStocks)
            {
                if (sortedStocks[index].getDay() <= sortedStocks[29].getDay() && sortedStocks[index].getPrice() <= sortedStocks[29].getPrice() ) {
                    Stock validStock = new Stock(sortedStocks[index].getPrice(), sortedStocks[index].getDay());
                    validStocks.Add(validStock);
                    // Console.WriteLine($"{sortedStocks[index].getDay()}({sortedStocks[index].getPrice()}), {sortedStocks[29].getDay()}({sortedStocks[29].getPrice()})");
                    // double difference = sortedStocks[29].getPrice() - sortedStocks[index].getPrice();
                    // Console.WriteLine(difference);
            }
               index++; 
            }

            Console.WriteLine(validStocks[0].getPrice());
            Console.WriteLine(validStocks[0].getDay());

            // Console.WriteLine(validStocks.Count);
            Console.WriteLine(validStocks[19].getPrice());
            Console.WriteLine(validStocks[19].getDay());

            // Console.WriteLine(sortedStocks[0].getPrice());
            // Console.WriteLine(sortedStocks[0].getDay());

            // Console.WriteLine(validStocks.Count);
            Console.WriteLine(sortedStocks[29].getPrice());
            Console.WriteLine(sortedStocks[29].getDay());


         

            // var min = validStocks.OrderBy(i => i.getPrice()).FirstOrDefault();
            // var max = validStocks.OrderBy(i => i.getPrice()).LastOrDefault();

            // var minDay = validStocks.OrderBy(i => i.getDay()).FirstOrDefault();
            // var maxDay = validStocks.OrderBy(i => i.getDay()).LastOrDefault();

            // Console.WriteLine(min.getPrice());
            // Console.WriteLine(minDay.getDay());
            // Console.WriteLine(max.getPrice());
            // Console.WriteLine(maxDay.getDay());



            // for all the stocks in sortedStocks
            // if the current sorted stocks day is less than the last one in the sortedStocks
            // AND the current sorted stocks price is less than the last one in the sorted stocks
            // print the results 

            // 15(15.28), 21(27.39) - for dataset 2

        
        }
    }
}
