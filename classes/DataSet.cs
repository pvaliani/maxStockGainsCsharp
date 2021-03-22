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
            string pricesMonth1 = System.IO.File.ReadAllText(@$"{filename}");
            // System.Console.WriteLine("ChallengeSampleDataSet1 values= {0}", pricesMonth1);

            // convert pricesMonth1 string to a list of double values and send each value to the console
            List<double> pricesMonth1AsList = pricesMonth1.Split(',').Select(double.Parse).ToList();
            pricesMonth1AsList.ForEach(Console.WriteLine);
            
            int index = 0; 
            List<Stock> stocks = new List<Stock>();

            foreach (var price in pricesMonth1AsList)
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


