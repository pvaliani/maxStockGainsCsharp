using System;
using System.IO;
using System.Collections.Generic;  
using System.Collections;
using System.Linq;



namespace computershare.classes
{
    public class DataSet
    {

        public string filename;
        public DataSet(string filename){
            this.filename = filename;
        }

        public string getFilename(){
            return filename;
        }

        public List<Stock> getDataSetValues(){

            // reads the string data from the text file specified containing prices
            string pricesFromFile = System.IO.File.ReadAllText(@$"{filename}");
 
            // convert pricesFromFile string to a list of doubles, parsing out commas
            List<double> pricesAsList = pricesFromFile.Split(',').Select(double.Parse).ToList();

            // sort the list in ascending order to be able to find the lowest and highest month price
            pricesAsList.Sort();

            // logs ordered prices to console - DELETE!
            pricesAsList.ForEach(Console.WriteLine);


            // initialise an index to track the price on a given day
            int index = 0; 
            List<Stock> stocks = new List<Stock>();

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


