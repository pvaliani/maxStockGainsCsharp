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

        public List<double> getDataSetValues(){
            string readValues = System.IO.File.ReadAllText(@"{filename}");
            List<double> dataSetValuesAsList = readValues.Split(',').Select(double.Parse).ToList();
            return dataSetValuesAsList;

    }
}