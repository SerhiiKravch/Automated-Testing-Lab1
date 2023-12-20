using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcClassBr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcClassBr.Tests
{
    [TestClass]

    public class UnitTest1
    {
        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Сергій\\source\\repos\\Lab_1_A_T\\CalcClassBrTests\\Data.mdf;Integrated Security=True;Connect Timeout=30";
        [TestMethod]
        [DataSource("System.Data.SqlClient", connectionString, "Table", DataAccessMethod.Sequential)]
        public void IABSTest()
        {
            long a = Convert.ToInt64(TestContext.DataRow["A"]);
            long excepted = Convert.ToInt64(TestContext.DataRow["Result"]);

            long result = CalcClass.IABS(a);
            Assert.AreEqual(result, excepted);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IABSTestOutOfRange()
        {
            long a = long.MaxValue;
            long result = CalcClass.IABS(a);

        }


        public TestContext TestContext { get; set; }
    }
}