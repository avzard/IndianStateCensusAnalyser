using System;
using System.Collections.Generic;
using System.Text;

namespace CensusAnalyser
{
    /// <summary>
    /// POCO Class for StateCensusData File.
    /// </summary>
    class CSVStateCensus
    {
        //Variables.
        private string state;
        private string population;
        private string areaInSqKm;
        private string denisityPerSqKm;

        /// <summary>
        /// Setters And Getters.
        /// </summary>
        public string State { get => state; set => state = value; }
        public string Population { get => population; set => population = value; }
        public string AreaInSqKm { get => areaInSqKm; set => areaInSqKm = value; }
        public string DenisityPerSqKm { get => denisityPerSqKm; set => denisityPerSqKm = value; }
    }
}