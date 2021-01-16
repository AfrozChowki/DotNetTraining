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
        /// <param name="bank">Takes argument of type Bank Class</param>
        /// <returns>IFSC Code based on bank type</returns>
        public static string GenerateIFSCCode(Type bankBranch)
        {
            string IfscCode = bankBranch switch
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
        /// <param name="bank">Takes argument of type Bank Class</param>
        /// <returns>Interest rate based on location(IFSC Code) and Type of Bank</returns>

        public static double GetInterestRate(string ifscCode, int customerCount, Type bankType)
        {
            var interestRate = (ifscCode, customerCount, bankType) switch
            {
                ("AXISP01", 1000, Type.Public) => 6.0,
                ("AXISC03", 900, Type.Commercial) => 2.0,
                ("AXISP02", 1100, Type.Private) => 8.0,
                _ => 4.0

            };
            return interestRate;
        }

        public static double UsingSwitchGetInterestRate(int customerCount, Type bankType)
        {
            switch(bankType)
            {
                case Type.Commercial when customerCount <= 1000:
                {
                    return 2.2;
                }
                case Type.Commercial:
                {
                    return 2.0;
                }
                case Type.Private:
                    return 8.0;
                case Type.Public:
                    return 6.0;
                default:
                    return 4.0;

            }
        }
    }

}
