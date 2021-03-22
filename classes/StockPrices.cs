namespace computershare.classes
{
    public class StockPrices
    {
        
        // import the stock data here and save as two arrays containing the prices
        public string prices;
        public string dataSetName;
        
        string pricesMonth1 = System.IO.File.ReadAllText(@"ChallengeSampleDataSet1.txt");
        // List<double> pricesMonth1AsList = pricesMonth1.Split(',').Select(double.Parse).ToList();
        // pricesMonth1AsList.ForEach(Console.WriteLine);



    }
}