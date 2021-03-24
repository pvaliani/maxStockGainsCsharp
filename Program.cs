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
            DataSet month2 = new DataSet("ChallengeSampleDataSet2.txt");

            List<Stock> stocksMonth1 = month1.getDataSetStocks();
             List<Stock> stocksMonth2 = month2.getDataSetStocks();
            

            // sort the stocks by ascending price, keeping note of their index position i.e day in the month
            List<Stock> sortedStocksMonth1 = stocksMonth1.OrderBy(o=>o.getPrice()).ToList();
            List<Stock> sortedStocksMonth2 = stocksMonth1.OrderBy(o=>o.getPrice()).ToList();

            // create indices to track the sortedStocksMonth1 objects and the ranking of the best stock combinations to make
            int index = 0;
            int index2  = 1;

            // loop through each sorted stock and because sortedStocksMonth1 has already been ordered by ascending price
            // compare the day of the current stock against the highest stock prices day
            // if the current stocks day is <= the last stock && its price is <= the price of the highest stock 
            // console log the ranked order of best trades starting with the best trade at the top

            Console.WriteLine("--------------START OF MONTH 1 STOCKS------------------------");

            foreach (var sortedStock in sortedStocksMonth1)
            {
                if (sortedStocksMonth1[index].getDay() <= sortedStocksMonth1[29].getDay() && sortedStocksMonth1[index].getPrice() <= sortedStocksMonth1[29].getPrice() ) {
            
                    Console.WriteLine($"Month 1: #{index2} valid trade is {sortedStocksMonth1[index].getDay()}({sortedStocksMonth1[index].getPrice()}), {sortedStocksMonth1[29].getDay()}({sortedStocksMonth1[29].getPrice()})");
        
                    index2++;
            }
               index++; 
            }


            Console.WriteLine("--------------END OF MONTH 1 STOCKS------------------------");

            int index3 = 0;
            int index4 = 1;

            Console.WriteLine("--------------START OF MONTH 2 STOCKS------------------------");

              foreach (var sortedStock in sortedStocksMonth2)
            {
                if (sortedStocksMonth2[index3].getDay() <= sortedStocksMonth2[29].getDay() && sortedStocksMonth2[index3].getPrice() <= sortedStocksMonth2[29].getPrice() ) {
            
                    Console.WriteLine($"Month 2: #{index4} valid trade is {sortedStocksMonth2[index3].getDay()}({sortedStocksMonth2[index3].getPrice()}), {sortedStocksMonth2[29].getDay()}({sortedStocksMonth2[29].getPrice()})");
        
                    index4++;
            }
               index3++; 
            }

            Console.WriteLine("--------------END OF MONTH 2 STOCKS------------------------");







            // ANSWER:
            // The best trades to be made for each data set in the form buyDayOfMonth(price), sellDayOfMonth(price) are:
            // 15(15.28), 21(27.39) - for dataset 1
            // 7(19.66), 14(27.2) - for dataset 2

        
        }
    }
}
