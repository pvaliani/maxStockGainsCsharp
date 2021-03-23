using System;
using System.IO;
using System.Collections.Generic;  
using System.Collections;
using System.Linq;

namespace computershare.classes
{
    public class DataSet
    {

        // a DataSet object has a filename property i.e filename associated with sample data sets 1 and 2
        public string filename;
        public DataSet(string filename){
            this.filename = filename;
        }

        // getter for file name
        public string getFilename(){
            return filename;
        }

        public List<Stock> getDataSetStocks(){

            // reads the string data from the text file specified containing prices
            string pricesFromFile = System.IO.File.ReadAllText(@$"{filename}");
 
            // convert pricesFromFile string to a list of doubles, parsing out commas
            List<double> pricesAsList = pricesFromFile.Split(',').Select(double.Parse).ToList();

            // sort the list in ascending order to be able to find the lowest and highest month price - currently this 
            // currently sorts the list of prices only
            pricesAsList.Sort();

            // // logs ordered prices to console - DELETE!
            // pricesAsList.ForEach(Console.WriteLine);

            // initialise an index to track the price of a stock on a given day
            int index = 0; 

            List<Stock> stocks = new List<Stock>();

            // for each price in the list of stock prices (ordered by day)
            // the day is equal to the index + 1
            // create a new stock object that uses the current price and assign it a day which is its index pos +1
            // add that stock to a list of stocks
            // increase the index by 1 each time

            foreach (var price in pricesAsList)
            {
                var day = index+1;
                Stock stock = new Stock(price, day);
                stocks.Add(stock);
                index++;
            }
            return stocks;
        }


        

    }

}


