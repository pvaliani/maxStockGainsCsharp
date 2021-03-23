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


public class StockTest
{
    [Fact]
    
    public void canGetStockPrice(){

    Stock stock1 = new Stock(30.4, 0);
    
    Assert.Equal(30.4, stock1.getPrice());
    }

    [Fact]

    public void canSetStockDay(){

    Stock stock1 = new Stock(50.3, 3);
    
    Assert.Equal(3, stock1.getDay());
    }
    




}}

