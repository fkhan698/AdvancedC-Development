using System;
using System.Collections.Generic;

namespace HelloWorld
{

    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player() { Name = "Bob", Strength = 20 };
            var warrior = new Warrior() { Name = "Baltek", Strength = 100, Bonus = 10 };
            var wizard = new Wizard() { Name = "Pentagorn", Strength = 50, Energy = 50 };

            var players = new List<Player>();
            players.Add(player);
            players.Add(warrior);
            players.Add(wizard);

            DoBattle(players);

            Console.ReadLine();
        }

        static void DoBattle(List<Player> players)
        {
            foreach (var player in players)
            {
                player.Attack();
                Console.WriteLine("");
            }
        }

        public class Player
        {
            public Player()
            {
            }

            public string Name { get; set; }
            public int Strength { get; set; }

            public virtual void Attack()
            {
                Console.WriteLine($"{ Name} attacked for {Strength} dammage");
            }
        }

        private class Warrior : Player
        {
            public Warrior()
            {
            }

            public int Bonus { get; set; }

            public override void Attack()
            {
                Console.WriteLine($"{ Name} attacked for {Strength} damage (includes + {Bonus} bonus) ");
            }
        }

        private class Wizard : Player
        {
            public Wizard()
            {
            }

            public int Energy { get; set; }

            public override void Attack()
            {
                Console.WriteLine($"{ Name} attacked for {Strength} damage (Wizard {Name} depleted {Energy} energy) ");
            }
        }
    }
}
