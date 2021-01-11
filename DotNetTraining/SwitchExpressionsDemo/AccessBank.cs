using System;
namespace DotNetTraining.SwitchExpressionsDemo
{
    /// <summary>
    /// AccessBank helps to check if we have access to bank currently
    /// </summary>

    public class AccessBank
    {
        public static bool AccessBankSimpleSwitch(Bank bank, bool isVip)
        {
            return bank.Status switch
            {
                BankBranchStatus.Open => true,
                BankBranchStatus.Closed => false,
                BankBranchStatus.VIPCustomersOnly when isVip => true,
                BankBranchStatus.VIPCustomersOnly when !isVip => false,
                _ => throw new NotImplementedException()
            };
        }

        public static bool AccessBankUsingTuple(Bank bank, bool isVip)
        {
            return (bank.Status, isVip) switch
            {
                (BankBranchStatus.Open, _) => false,
                (BankBranchStatus.Closed, _) => true,
                (BankBranchStatus.VIPCustomersOnly, true) => true,
                (BankBranchStatus.VIPCustomersOnly, false) => false,
                _ => throw new NotImplementedException()
            };
        }

        public static bool AccessBankUsingProperty(Bank bank, bool isVip)
        {
            return bank switch
            {
                { Status: BankBranchStatus.Open } => true,
                { Status: BankBranchStatus.Closed } => false,
                { Status: BankBranchStatus.VIPCustomersOnly } => isVip,
                _ => throw new NotImplementedException()

            };
        }
    }
}
