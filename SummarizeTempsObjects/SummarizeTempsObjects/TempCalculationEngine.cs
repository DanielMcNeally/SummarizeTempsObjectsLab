using System.Collections.Generic;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;

        }

        public int AverageTemperature()
        {
            // add logic to calculate the average
            int sumOfTemps = 0;
            // loop through all the tempsin the list
            foreach (int temps in _temperatures)

                // add each temp to my sum varible
                sumOfTemps += temps;
            //divide sum varible by the list count
            int averageTemps = sumOfTemps / _temperatures.Count;
            return averageTemps; // <-- Replace this with the actual average
            //sum of all intergers/ num of intergers
        }

        public int TempsAboveThreshold(int threshold)
        {
            // add logic to calculate temps above the threshold
            int tempsAboveThreshold = 0;

            foreach (int temps in _temperatures)
                if (temps > threshold)
                {
                    tempsAboveThreshold += 1;
                }
            //test if num above or below
            
            return tempsAboveThreshold; // <-- Replace this with the number
            
        }

        public int TempsBelowThreshold(int threshold)
        {
            // add logic to calculate and return temps below the threshold
            int tempsBelowThreshold = 0;
            foreach (int temps in _temperatures)
                if (temps < threshold)
            {
                tempsBelowThreshold += 1;
            }
            return tempsBelowThreshold; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            // add logic to calculate and return temps at the threshold
            int tempsAtThreshold = 0;
            foreach (int temps in _temperatures)
                    if (temps == threshold)
                {
                    tempsAtThreshold += 1;
                }
            return tempsAtThreshold; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            return _temperatures.Count; // <-- Replace this with the number
            //
        }
    }
}
