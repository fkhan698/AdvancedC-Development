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
            taxableItems.Add(new  Book{ Price= 20, ShippingRate =  4, TaxRate = 0.06D});
            taxableItems.Add(new TShirt { Price = 5, ShippingRate = 2, TaxRate = 0.07D });

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
            CollectionAssert.AllItemsAreInstancesOfType(shippableItems, typeof(IShippable));
        }
        #endregion
        #region CheckPurchaseableItems
        [TestMethod]
        public void CheckPurchaseAbleItems()
        {
            //Arrange
            var purchaseableItems = new List<IPurchasable>();

            //Act
            purchaseableItems.Add(new Snack { Price = 2 });
            purchaseableItems.Add(new TShirt { Price = 10, ShippingRate = 1, Size = "Small", TaxRate = 0.06D });

            //Assert
            CollectionAssert.AllItemsAreInstancesOfType(purchaseableItems, typeof(IPurchasable));


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
        #region CheckAreNotSame
        [TestMethod]
        public void CheckIfNotSame()
        {
            //Arrange
            var book = new Book();
            var shirt = new TShirt();
            //Assert
            Assert.AreNotSame(book, shirt);

            
        }
        #endregion
        #region CheckTaxDouble
        [TestMethod] 
        public void TaxDouble()
        {
            //Arrange
            var taxableItems = new List<ITaxable> {
               new Book {Title = "Clean Code", Price = 15D, ShippingRate = 2, TaxRate = 0.07D},
               new TShirt{Price = 5, ShippingRate = 3, TaxRate = 0.08D}
            };

            var tax = Homework2.Program.CalculateTax(taxableItems);

            Assert.IsInstanceOfType(tax, typeof(double));

        }
        #endregion
        #region CheckShipRateDouble
        [TestMethod]
        public void ShipRateDouble()
        {
            //Arrange
            var shippableItems = new List<IShippable> {
               new Book {Title = "Clean Code", Price = 15D, ShippingRate = 2, TaxRate = 0.07D},
               new TShirt{Price = 5, ShippingRate = 3, TaxRate = 0.08D}
            };

            var ship = Homework2.Program.CalculateShipping(shippableItems);

            Assert.IsInstanceOfType(ship, typeof(double));

        }
        #endregion
        #region CheckTitleString
        [TestMethod]
        public void CheckTitleString()
        {
            var book = new Book()
            {
                Title = "Welcome to Advanced C#"
            };

            var title = book.Title;

            Assert.IsInstanceOfType(title, typeof(string));


        }
        #endregion  



    }
}
