using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4EX2B4.TightCoupling.Model
{
    public class CashSaleOrder : Order
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
            if (_paymentDetails.PaymentMethod == PaymentMethod.Cash)
            {
                _paymentProcessor.ChargeCash( _cart.TotalAmount);
            }
            
        }

      
    }
}
