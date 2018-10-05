using Convertor3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestConvertor3
{
    
        [TestClass]
        public class UnitTest1
        {
            ConvertorClass c1 = new ConvertorClass();

            /// <summary>
            ///     Test the method that converts grams to ounces
            /// </summary>
            [TestMethod]
            public void TestConvertToOunces()
            {
                double result = c1.ConvertToOunces(30);
                Assert.AreEqual(1.05822, result, 0.001);
            }

            /// <summary>
            ///     Tests the method that converts ounces to grams
            /// </summary>
            [TestMethod]
            public void TestConvertToGrams()
            {
                double result = c1.ConvertToGrams(30);
                Assert.AreEqual(850.486, result, 0.001);
            }
        }
    
}
