using System;
using System.IO;
using System.Collections.Generic;  
using System.Collections;
using System.Linq;


namespace computershare.classes
{
    public class CalculateMaxGain
    {
        // initialise the new stockPrices
        public Stock month1prices;

        public Stock month2prices;

        public DataSet month1data;

        public CalculateMaxGain(){

              // create new price objects to calculate maximum gain
        Stock month1Prices = new Stock(44.4, 1);
        Stock month2Prices = new Stock(33.3, 1);

        DataSet month1data = new DataSet("ChallengeSampleDataSet1.txt");


        }




        // import the serialized csv data as objects that can be iterated over
        // calculate the maximum gain as a pair of values of format buyDayOfMonth(price),sellDayOfMonth(price)
        // console.writeline() the output value
    }
}