using System;

using System.Net.Mail;
using HW3EX1B4.Services;
using HW3EX1B4.Utility;

namespace HW3EX1B4.Model
{
    public abstract class Order
    {

        public abstract void Checkout(Cart cart, PaymentDetails paymentDetails, bool notifyCustomer);
        public abstract void ReserveInventory(Cart cart);
        public abstract void NotifyCustomer(Cart cart);
        public abstract void Charge(PaymentDetails paymentDetails, Cart cart);

    }
}

    public class OrderException : Exception
    {
        public OrderException(string message, Exception innerException)
            : base(message, innerException)
        {            
        }
    }