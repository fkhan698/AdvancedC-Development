namespace DIP_Demo
{
    public class Chore : IChore
    {
        ILogger _ilogger;
        IMessageSender _messageSender;

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public Chore(ILogger logger, IMessageSender messageSender)
        {
            _ilogger = logger;
            _messageSender = messageSender;
        }

        public void PerformedChore(double hours)
        {
            HoursWorked += hours;
           
            _ilogger.Log($"{Owner.FirstName} performed work on {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;

            
            _ilogger.Log($"Completed {ChoreName} is complete and it it took {HoursWorked} hours.");

          
            _messageSender.SendMessage(Owner, $"The chore {ChoreName} is complete and it took {HoursWorked} hours");
        }
    }
}