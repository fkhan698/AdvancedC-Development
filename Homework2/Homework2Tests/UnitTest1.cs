using Homework2;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Homework2Tests
{
    [TestClass]
    public class UnitTest1
    {
        #region BookTitleExists
        [TestMethod]
        public void BookNameExists()
        {
            //Arrange
            var book = new Book() { 
            Title = "Welcome to Advanced C#"
            
            };
         

            //Act
            var actualName = "Welcome to Advanced C#";

            //Assert 
            Assert.AreEqual(book.Title, actualName);
        }
        #endregion
        #region CheckAppointmentDetails
        [TestMethod]
        public void AppointmentDetails()
        {
            //Arrange
            var appointment = new Appointment()
            {
                Name = "James",
                Price = 100D
            };


            //Act
            var expectedName = "James";
            var expectedPrice = 100D;

            //Assert 
            Assert.AreEqual(expectedName, appointment.Name);
            Assert.AreEqual(expectedPrice, appointment.Price);
        }
        #endregion
        #region CheckTaxableItems
        [TestMethod]
        public void CheckTaxableItems()
        {
            //Arrange
            var taxableItems = new List<ITaxable>();


            //Act
            taxableItems.Add(new TShirt { Price= 10, ShippingRate =  1, Size = "Small", TaxRate = 0.06D});

            //Assert 
           CollectionAssert.AllItemsAreInstancesOfType(taxableItems, typeof(ITaxable));
        }
        #endregion
        #region CheckShippableItems
        [TestMethod]
        public void CheckShippableItems()
        {
            //Arrange 
            var shippableItems = new List<IShippable>();
            //Act
            shippableItems.Add(new TShirt { Price = 10, ShippingRate = 1, Size = "Small", TaxRate = 0.06D });
            //Assert 
        }
        #endregion
        #region CheckGrandTotal
        [TestMethod]
        public void CheckGrandTotal()
        {
            //Arrage 
            double shippingAmount = 2;
            double taxAmount = 2.50;
            double grandTotal;

            //Act
            grandTotal = shippingAmount + taxAmount;

            //Assert
            Assert.AreEqual(grandTotal, 4.50);
        }
        #endregion

        #region CheckTaxRate
        [TestMethod]
        public void CheckTaxRate()
        {
            //Arrange
            var book = new Book();
            var shirt = new TShirt();

            Assert.AreNotSame(book, shirt);

            
        }
        #endregion
    }
}
