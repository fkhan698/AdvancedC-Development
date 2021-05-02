using System;
using Microsoft.Extensions.DependencyInjection;

namespace DIP_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            var diContainer = Startup.ConfigureService();

            //IPerson owner = Factory.CreatePerson();
            var owner = diContainer.GetRequiredService<IPerson>();

            owner.FirstName = "James";
            owner.LastName = "Bateman";
            owner.EmailAddress = "jamesbateman@msu.edu";
            owner.PhoneNumber = "555-1212";


            //IChore chore = Factory.CreateChore();
            var chore = diContainer.GetRequiredService<IChore>();

            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;
           

            chore.PerformedChore(3);
            chore.PerformedChore(1.5);
            chore.CompleteChore();

            Console.ReadLine();
            
        } 
    }
}
