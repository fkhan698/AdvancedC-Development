namespace DIP_Demo
{
    public interface IChore
    {
        string ChoreName { get; set; }
        double HoursWorked { get; }
        bool IsComplete { get; }
        IPerson Owner { get; set; }

        void CompleteChore();
        void PerformedChore(double hours);
    }
}