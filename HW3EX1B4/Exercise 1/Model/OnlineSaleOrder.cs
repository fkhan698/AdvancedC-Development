using HW3EX1B4.Services;
using HW3EX1B4.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HW3EX1B4.Model
{
    public class OnlineSaleOrder : Order
    {
        public override void Checkout(Cart cart, PaymentDetails paymentDetails, bool notifyCustomer)
        {
            Charge(paymentDetails, cart);
           
            ReserveInventory(cart);

            if (notifyCustomer)
            {
                NotifyCustomer(cart);
            }
        }


        public override void ReserveInventory(Cart cart)
        {
            Inventory.ReserveInventory(cart);
        }
        public override void NotifyCustomer(Cart cart)
        {
            Notify.NotifyCustomer(cart);
        }

        public override void Charge(PaymentDetails paymentDetails, Cart cart)
        {
            if (paymentDetails.PaymentMethod == PaymentMethod.CreditCard)
            {
                ChargeItems.ChargeCard(paymentDetails, cart);
            }
        }
    }
}
