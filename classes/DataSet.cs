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
               // reads the first dataset as a single string which can be deserialized
            string pricesFromFile = System.IO.File.ReadAllText(@$"{filename}");
            // System.Console.WriteLine("ChallengeSampleDataSet1 values= {0}", pricesFromFile);

            // convert pricesFromFile string to a list of double values and send each value to the console
            List<double> pricesAsList = pricesFromFile.Split(',').Select(double.Parse).ToList();
            pricesAsList.Sort();
            
            pricesAsList.ForEach(Console.WriteLine);
            
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


