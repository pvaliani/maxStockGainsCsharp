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

            // foreach (Stock i in stocks)
            // {
            //     Console.WriteLine(i.day);
            // }
            

            // DataSet month2 = new DataSet("ChallengeSampleDataSet2.txt");
            // List<Stock> stocks2 = month2.getDataSetValues();


        }
    }
}
