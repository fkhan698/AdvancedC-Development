using HW4EX2B4.TightCoupling.Services;

namespace HW4EX2B4.TightCoupling.Model
{
    public abstract class Order
    {
         Cart _cart;
      


        /*
            Dependency Inversion Principle
         *  High-level modules should not depend on low-level modules. Both should depend on abstractions. 
            Abstractions should not depend on details. Details should depend on abstractions
         */
        public virtual void OrderItems(Cart cart)
        {
            _cart = cart;
        }

        public abstract void Checkout(bool shouldnotifycustomer);
        

       
    }
}

