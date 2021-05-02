using HW4EX2B4.TightCoupling.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HW4EX2B4.TightCoupling.Model
{
    public class Factory
    {


        public static PaymentGateway CreatePayment()
        {
             return new PaymentGateway();
        }

        public static InventorySystem ReserveInventory()
        {
            return new InventorySystem();
        }

        //public static MailMessage MailMessager()
        //{
        //    return new MailMessage(string, );
        //}

        public static SmtpClient Client()
        {
            
            return new SmtpClient("localhost");
        }

      
    }
}
