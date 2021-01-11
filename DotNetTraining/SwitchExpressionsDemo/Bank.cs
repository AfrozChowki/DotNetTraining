
namespace DotNetTraining.SwitchExpressionsDemo
{
    /// <summary>
    /// Bank class helps to know status of a bank 
    /// </summary>

    public class Bank
    {
        public BankBranchStatus Status { get; set; }

    }
    //enum gives us status of bank
    public enum BankBranchStatus
    {
        Open,
        Closed,
        VIPCustomersOnly
    }
}
