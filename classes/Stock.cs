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


    }
}