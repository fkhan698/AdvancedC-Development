using System;

namespace ISPExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            BurgerOrderService order = new BurgerOrderService();
            ComboOrderService combo = new ComboOrderService();
            order.orderBurger(2);       // only want a burger only order
            combo.orderCombo(2, 1);
            
        }
    }


    interface IOrderBurger
    {
        void orderBurger(int quantity);
    }

    interface IOrderFries
    {
        void orderFries(int fries);
    }

    interface IOrderCombo
    {
        void orderCombo(int quantity, int fries);
    }

    public class BurgerOrderService : IOrderBurger
    {
        public void orderBurger(int quantity)
        {
            Console.WriteLine($"Received order for {quantity} burgers");
        }

        public void orderCombo(int quantity, int fries)
        {
            throw new NotImplementedException("No combo in burger only order");
        }
    }

    public class FriesOrderService : IOrderFries
    {
        public void orderFries(int fries)
        {
            Console.WriteLine($"Received order for {fries} burgers");
        }
    }

    public class ComboOrderService : IOrderCombo
    {
        public void orderCombo(int quantity, int fries)
        {
            Console.WriteLine($"Received order for {quantity} burgers and {fries} fries");
        }
    }
}
