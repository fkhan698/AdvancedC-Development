using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4EX2B4.TightCoupling.Model
{
    public class OnlineSaleOrder : Order
    {
        Cart _cart;
        PaymentDetails _paymentDetails;
        IPaymentProcessor _paymentProcessor;

        public override void OrderItems(Cart cart)
        {
            throw new NotImplementedException();
        }

        public override void Checkout(bool shouldNotifyCustomer)
        {
            if (_paymentDetails.PaymentMethod == PaymentMethod.CreditCard)
            {
                _paymentProcessor.ChargeCard(_paymentDetails, _cart.TotalAmount);
            }
            
        }
    }
}
