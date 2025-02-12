using Microsoft.VisualStudio.TestTools.UnitTesting;
using celloveszetCLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetCLI.Tests
{
    [TestClass()]
    public class CellovoTests
    {   
        [TestMethod()]
        [DataRow(22,29,12,23,29)]
        [DataRow(16, 45, 87, 33, 87)]
        [DataRow(96, 49, 67, 45, 96)]
        [DataRow(44, 3, 12, 77, 77)]
        public void legnagyobbTest(int l1,int l2, int l3, int l4, int excepted)
        {
            Cellovo cellovo =  new Cellovo($"Test;{l1};{l2};{l3};{l4}");
            Assert.AreEqual(excepted, cellovo.legnagyobb());
        }

     
    }
}