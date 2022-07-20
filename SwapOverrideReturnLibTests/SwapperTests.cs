using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwapOverrideReturnLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapOverrideReturnLib.Tests
{
    [TestClass()]
    public class SwapperTests
    {
        [TestMethod()]
        public void ValueSwapTest()
        {
            int X = 5, Y = 9, Z = 15;
            Swapper.ValueSwap(ref X, ref Y, ref Z);
            Assert.IsTrue(X == 9 && Y == 15 && Z == 5);
        }
    }
}