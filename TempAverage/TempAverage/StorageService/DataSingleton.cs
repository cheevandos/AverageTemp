using System;
using System.Collections.Generic;

namespace TempAverage.StorageService
{
    public class DataSingleton
    {
        private static DataSingleton instance;
        public Dictionary<DateTime, double> Measurements { get; set; }

        private DataSingleton()
        {
            Measurements = new Dictionary<DateTime, double>();
        }

        public static DataSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DataSingleton();
            }
            return instance;
        }
    }
}
