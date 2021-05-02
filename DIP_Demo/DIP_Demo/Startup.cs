using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace DIP_Demo
{
    class Startup
    {
        public static IServiceProvider ConfigureService()
        {
            var provider = new ServiceCollection()
                .AddSingleton<IPerson, Person>()
                .AddSingleton<IChore, Chore>()
                .AddSingleton<ILogger, Logger>()
                .AddSingleton<IMessageSender, Emailer>()
                .BuildServiceProvider();

            return provider;
        }
    }
}
