using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SwitchExpressionsDemo
{
    public class BankHelper
    {
        /// <summary>
        /// Helps to get customer capacity of a bank
        /// </summary>
        /// <param name="bank">Takes argument of type Bank Class</param>
        /// <returns>Customer Count of a particular bank</returns>
        public static int GetCustomerCount(Bank bank) => bank switch
        {
            { IFSCCode: "AXISP01" } => 1000,
            { IFSCCode: "AXISP02" } => 1100,
            { IFSCCode: "AXISC03" } => 900,
            _ => 300

        };
        /// <summary>
        /// Helps to generate IFSC Code for a bank
        /// </summary>
        /// <param name="bankBranch">Takes argument of type Bank Class</param>
        /// <returns>IFSC Code based on bank type</returns>
        public static string GenerateIFSCCode(Type bankBranch)
        {
            var IfscCode = bankBranch switch
            {
                Type.Public => "AXISP01",
                Type.Private => "AXISP02",
                Type.Commercial => "AXISC03",
                _ => "DefaultBranch"
            };
            return IfscCode;
        }
        /// <summary>
        /// Helps to get Interest given by a bank
        /// </summary>
        /// <param name="ifscCode">Takes argument of IFSC Code of a bank</param>
        /// <param name="customerCount">Takes argument of customer count of a bank</param>
        /// <param name="bankType">Takes an argument of type of bank</param>
        /// <returns>Interest rate based on location(IFSC Code) and Type of Bank</returns>

        public static double GetInterestRate(string ifscCode, int customerCount, Type bankType)
        {
            var interestRate = (ifscCode, customerCount, bankType) switch
            {
                (_, _, Type.Public) => 6.0,
                (_, 900, Type.Commercial) => 2.0,
                (_, 1100, Type.Private) => 8.0,
                ("AXISC02",1100,Type.Commercial) =>2.4,
                _ => 4.0

            };
            return interestRate;
        }

        public static double UsingSwitchGetInterestRate(Bank bank)
        {
            switch(bank.BankType,bank.CustomerCount)
            {
                case (Type.Commercial,1100):
                {
                    return 2.2;
                }
                case (Type.Commercial,_):
                {
                    return 2.0;
                }
                case (Type.Private,_):
                    return 8.0;
                case (Type.Public,_):
                    return 6.0;
                default:
                    return 4.0;

            }
        }

        public static void UpdateBank(Bank bank)
        {
            bank.CustomerCount = 1100;
            bank.IFSCCode = "AXISC02";
            bank.InterestRate = BankHelper.GetInterestRate(bank.IFSCCode, bank.CustomerCount, bank.BankType);
            bank.Name = "AXIS Special Bank";
        }
    }

}
