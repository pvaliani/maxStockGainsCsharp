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

        // define a stock object as having a price and day associated with the opening price
        public Stock(double price, int day){
            this.price = price;
            this.day = day;
        }

        // getters and setters for prices and day
        public double getPrice() {
        return price;
        }

        public void setPrice(double price) {
            this.price = price;
        }

         public int getDay() {
             return day;
        }

         public void setDay(int day) {
            this.day = day;
        }


    }
}