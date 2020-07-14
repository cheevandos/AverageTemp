using System;
using System.Collections.Generic;
using System.Linq;
using TempAverage.StorageService;

namespace TempAverage.Logic
{
    public class DataLogic
    {
        private readonly DataSingleton source;

        public DataLogic()
        {
            source = DataSingleton.GetInstance();
        }

        public void AddMeasurement(DateTime date, double temp)
        {
            if (source.Measurements.ContainsKey(date))
            {
                throw new Exception("Уже есть измерение с такой датой");
            }
            source.Measurements.Add(date, temp);
        }

        public Dictionary<DateTime, double> GetMeasurements()
        {
            return source.Measurements.OrderBy(msmnt => msmnt.Key)
                .ToDictionary(msmnt => msmnt.Key, msmnt => msmnt.Value);
        }

        public void DeleteMeasurement(DateTime key)
        {
            if (!source.Measurements.ContainsKey(key))
            {
                throw new Exception("Измерение не найдено");
            }
            else
            {
                source.Measurements.Remove(key);
            }
        }

        public double GetAverageTemp()
        {
            if (source.Measurements.Count > 0)
            {
                return source.Measurements.Average(msmnt => msmnt.Value);
            }
            else
            {
                throw new Exception("Нет ни одного измерения");
            }
        }
    }
}
