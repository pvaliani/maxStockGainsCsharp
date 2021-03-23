using Xunit;
using System;
using System.IO;
using System.Collections.Generic;  
using System.Collections;
using System.Linq;
using computershare.classes;
using System.Reflection;
using System.Text;

namespace computershare.tests
{


public class DataSetTest
{


    [Fact]
    
    public void canReadDataSet1(){

    string path =  System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + @"../../../", "ChallengeSampleDataSet1.txt");

    string pricesFromFile = System.IO.File.ReadAllText(path);
    string data  = "18.93,20.25,17.05,16.59,21.09,16.22,21.43,27.13,18.62,21.31,23.96,25.52,19.64,23.49,15.28,22.77,23.1,26.58,27.03,23.75,27.39,15.93,17.83,18.82,21.56,25.33,25,19.33,22.08,24.03";
    
    Assert.Equal(data, pricesFromFile);

    }

    [Fact]
    
    public void canReadDataSet2(){

    string path =  System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + @"../../../", "ChallengeSampleDataSet2.txt");

    string pricesFromFile = System.IO.File.ReadAllText(path);
    string data  = "22.74,22.27,20.61,26.15,21.68,21.51,19.66,24.11,20.63,20.96,26.56,26.67,26.02,27.20,19.13,16.57,26.71,25.91,17.51,15.79,26.19,18.57,19.03,19.02,19.97,19.04,21.06,25.94,17.03,15.61";
    
    Assert.Equal(data, pricesFromFile);
    }


    [Fact]
    
    public void canAccessPriceFromListofPrices(){

    string path =  System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + @"../../../", "ChallengeSampleDataSet1.txt");

    string pricesFromFile = System.IO.File.ReadAllText(path);
    
    List<double> pricesAsList = pricesFromFile.Split(',').Select(double.Parse).ToList();

    Assert.Equal(17.05, pricesAsList[2]);
    }

    [Fact]
    public void canSortPricesAscendingOrder(){

    string path =  System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + @"../../../", "ChallengeSampleDataSet1.txt");

    string pricesFromFile = System.IO.File.ReadAllText(path);
    
    List<double> pricesAsList = pricesFromFile.Split(',').Select(double.Parse).ToList();

    pricesAsList.Sort();

    List<double> sorted = new List<double>() {
        15.28, 15.93, 16.22,
        16.59, 17.05,
        17.83, 18.62, 18.82,
        18.93, 19.33, 19.64,
        20.25, 21.09, 21.31,
        21.43, 21.56, 22.08,
        22.77, 23.1, 23.49,
        23.75, 23.96, 24.03,
        25, 25.33, 25.52, 
        26.58, 27.03, 27.13,
        27.39
    };


    Assert.Equal(pricesAsList, sorted );




    }





}}

