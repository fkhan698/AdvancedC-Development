using HW4EX2B4.TightCoupling.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW4EX2B4.TightCoupling
{
    [TestClass]
    public class OrderCheckoutShould
        
    {
       
        [TestMethod]
        public void NotFailWithNoItemsNoNotificationCreditCard()
        {

            var reservationService = new FakeReserveInventory();
            var paymentService = new FakePaymentProcessor();
            var notificationService = new FakeNotifyCustomer();
            var paymentDetails = new PaymentDetails() {PaymentMethod = PaymentMethod.CreditCard};

            var cart = new Cart();
            var order = new OnlineSaleOrder();

            bool shouldnotifycustomer = false;

            order.Checkout(shouldnotifycustomer);

            Assert.IsTrue(paymentService.wasCalled);

            // if I got here, I guess it worked...
        }

        [TestMethod]
        public void NotFailWithNoItemsNotificationNoCreditCard()
        {
            var reservationService = new FakeReserveInventory();
            var paymentService = new FakePaymentProcessor();
            var notificationService = new FakeNotifyCustomer();
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.Cash };

            var cart = new Cart();
            var order = new CashSaleOrder();

            bool shouldnotifycustomer = true;

            order.Checkout(shouldnotifycustomer);

            Assert.IsTrue(notificationService.wasCalled);
        }
    }
}
