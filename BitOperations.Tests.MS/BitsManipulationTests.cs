using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BitOperations.Tests.MS
{
    [TestClass]
    public class BitsManipulationTests
    {
        private const string FilePath = "|DataDirectory|\\Cases.xml";
        private const string DataSource = "Microsoft.VisualStudio.TestTools.DataSource.XML";
        private const string ItemPath = "BitOperations.Tests.MS\\Cases.xml";

        [TestClass()]
        public class NumberTests
        {
            public TestContext TestContext { get; set; }

            [DataSource(DataSource, FilePath, "TestCase", DataAccessMethod.Sequential)]
            [DeploymentItem(ItemPath)]
            [TestMethod]
            public void GetModifiedNumber_ConcreteValues_ThrowArgumentOutOfRangeException()
            {
                int numberSource = Convert.ToInt32(TestContext.DataRow["NumberSource"]);
                int numberInsert = Convert.ToInt32(TestContext.DataRow["NumberInsert"]);
                int startBitIndex = Convert.ToInt32(TestContext.DataRow["StartBitNumber"]);
                int endBitIndex = Convert.ToInt32(TestContext.DataRow["EndBitNumber"]);
                int actual = BitsManipulation.GetModifiedNumber(numberSource, numberInsert, startBitIndex, endBitIndex);
                int expected = Convert.ToInt32(TestContext.DataRow["Expected"]);
            }

            [DataSource(DataSource, FilePath, "BitNumberGreater31", DataAccessMethod.Sequential)]   
            [DeploymentItem(ItemPath)]
            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void GetModifiedNumber_BitNumberGreaterThan31_ThrowArgumentOutOfRangeException()
            {
                int startBitNumber = Convert.ToInt32(TestContext.DataRow["StartBitNumber"]);
                int endBitNumber = Convert.ToInt32(TestContext.DataRow["EndBitNumber"]);
                BitsManipulation.GetModifiedNumber(15, 8, startBitNumber, endBitNumber);
            }

            [DataSource(DataSource, FilePath, "NegativeBitNumber", DataAccessMethod.Sequential)]
            [DeploymentItem(ItemPath)]
            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void GetModifiedNumber_NegativeBitNumber_ThrowArgumentOutOfRangeException()
            {
                int startBitNumber = Convert.ToInt32(TestContext.DataRow["StartBitNumber"]);
                int endBitNumber = Convert.ToInt32(TestContext.DataRow["EndBitNumber"]);
                BitsManipulation.GetModifiedNumber(15, 8, startBitNumber, endBitNumber);
            }

            [DataSource(DataSource, FilePath, "StartGreaterThanEnd", DataAccessMethod.Sequential)]
            [DeploymentItem(ItemPath)]
            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void GetModifiedNumber_StartGreaterThanEnd_ThrowArgumentOutOfRangeException()
            {
                int startBitNumber = Convert.ToInt32(TestContext.DataRow["StartBitNumber"]);
                int endBitNumber = Convert.ToInt32(TestContext.DataRow["EndBitNumber"]);
                BitsManipulation.GetModifiedNumber(15, 8, startBitNumber, endBitNumber);
            }
        }
    }
}
