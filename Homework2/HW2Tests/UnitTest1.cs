using Homework2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW2Tests
{
    [TestClass]
    public class UnitTest1
    {

        #region Check Title of Book
        [TestMethod]
        public void CheckBookDetails()
        {
            //Arrange 
            var book = new Book();
          
            //Act 
            var actualTitle = "Welcome to Advanced C#";
            var actualPrice = 50D;
            var actualTaxRate = 0.0825D;
            var actualShippingRate = 5D;

            //Assert
            Assert.AreEqual(actualTitle, book.Title);
            Assert.AreEqual(actualPrice, book.Price);
            Assert.AreEqual(actualTaxRate, book.TaxRate);
            Assert.AreEqual(actualShippingRate, book.ShippingRate);
        }

        #endregion
    }
}
