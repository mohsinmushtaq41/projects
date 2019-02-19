using Calculater;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaterTest
{
    [TestClass]
    class CalculaterProgramTest
    {
        [TestMethod]
        public void AddTest()
        {
            // Arrange data
            CalculaterProgram cal = new CalculaterProgram();

            // Act
            int result = cal.Add(10,5);
            // Assert
            Assert.AreEqual(15,result);
          

        }
        [TestMethod]
        public void SubTest()
        {
            // Arange
            CalculaterProgram cal = new CalculaterProgram();
            
            // Act
            int result = cal.Sub(30, 5);
            // Assert
            Assert.AreEqual(25,result);

        }

    }
}
