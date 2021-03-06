using CensusAnalyser;
using NUnit.Framework;
using System;
using System.IO;

namespace CensusAnalyserTest
{
    /// <summary>
    /// Class For Test Cases.
    /// </summary>
    public class Tests
    {
        static string StateCensusFilePath = @"C:\Users\admin\OneDrive\Desktop\Indian State Census Analyser\IndianStateCensusAnalyser\CensusAnalyser\StateCensusData.csv";
        static string delimiter = ",";

        /// <summary>
        /// Test Case 1.1 Ensuring the number Of Record Matches.
        /// </summary>
        [Test]
        public void GivenStateCensusDataFileShouldReturnValidRecords()
        {
            int expectedNoOFRecords = 29;
            int records = StateCensusAnalyser.ReadStateCensus(StateCensusFilePath, delimiter);
            Assert.AreEqual(expectedNoOFRecords, records);
        }

        /// <summary>
        /// Test Case 1.2 Given Invalid File Should Throw Custom Exception.
        /// </summary>
        [Test]
        public void GivenInvalidFileShouldThrowException()
        {
            string expected = "Invalid File";
            string filePath = @"C:\Users\admin\OneDrive\Desktop\Indian State Census Analyser\IndianStateCensusAnalyser\CensusAnalyser\AnyFile.csv";
            try
            {
                int records = StateCensusAnalyser.ReadStateCensus(filePath, delimiter);
            }
            catch (Exception exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// Test Case 1.3 Given Invalid File Type Should throw Exception.
        /// </summary>
        [Test]
        public void GivenFileWithAnyTypeShouldThrowException()
        {
            string expected = "Invalid File Type";
            string filePath = @"C:\Users\admin\OneDrive\Desktop\Indian State Census Analyser\IndianStateCensusAnalyser\CensusAnalyser\StateCensusData.csv";
            try
            {
                int records = StateCensusAnalyser.ReadStateCensus(filePath, delimiter);
            }
            catch (Exception exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// Test Case 1.4 Given Invalid Delimiter Should Throw Exception.
        /// </summary>
        [Test]
        public void GivenInvalidDelimiterShouldThrowException()
        {
            string expected = "Invalid Delimiter";
            string custom_Delimiter = ";";
            try
            {
                int records = StateCensusAnalyser.ReadStateCensus(StateCensusFilePath, custom_Delimiter);
            }
            catch (Exception exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// Test Case 1.5 Given File with Invalid Header Should Exception.
        /// </summary>
        [Test]
        public void GivenFileWithInvalidHeaderShouldThrowException()
        {
            string expected = "Invalid Header";
            string filePath = @"C:\Users\admin\OneDrive\Desktop\Indian State Census Analyser\IndianStateCensusAnalyser\CensusAnalyser\StateCensusData.csv";
            try
            {
                int records = StateCensusAnalyser.ReadStateCensus(filePath, delimiter);
            }
            catch (Exception exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}