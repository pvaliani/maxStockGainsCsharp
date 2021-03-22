using System;
using System.IO;
using System.Collections.Generic;  
using System.Collections;
using System.Linq;


namespace computershare.classes
{
    public class Stock
    {
        private double price; 
        private int day;

        
        public Stock(double price, int day){
            this.price = price;
            this.day = day;
          

        }

        // getters and setters for prices and the data set name
        public double getPrice() {
        return price;
        }

        public void setPrice(double price) {
            this.price = price;
        }

         public int getBuyDayOfMonth() {
             return day;
        }

         public void setBuyDayOfMonth(int day) {
            this.day = day;
        }


// take list of stock, sort by price 
    

        // initialise double representing the dataset file name
        // public double dataSetName;

        // initialise prices stored in data file
        // public double prices = System.IO.File.ReadAllText(@"{dataSetName}");
        // List<double> pricesMonth1AsList = prices.Split(',').Select(double.Parse).ToList();
        // pricesMonth1AsList.ForEach(Console.WriteLine);



    }
}