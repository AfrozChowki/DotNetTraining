namespace SwitchExpressionsDemo
{
        /// <summary>
        /// Bank class helps us to demonstrate switch expressions
        /// </summary>
        public class Bank
        {

            public Type BankType { get; set; }
            public string Name { get; set; }

            public string IFSCCode { get; set; }

            public int CustomerCount;
            public double InterestRate;
            /// <summary>
            /// Constructor Helps To Assign Necessary Values
            /// </summary>
            /// <param name="bankType">Takes Input of enum Type</param>
            public Bank(Type bankType)
            {
                BankType = bankType;
                Name = "AXIS Bank";
                IFSCCode = BankHelper.GenerateIFSCCode(bankType);
                CustomerCount = BankHelper.GetCustomerCount(this);
                InterestRate = BankHelper.GetInterestRate(IFSCCode, CustomerCount, BankType);
            }

            /// <summary>
            /// Helps to get details of a Bank object
            /// </summary>
            /// <returns>Details Of Bank</returns>
            public override string ToString()
            {
                return "Bank Name : " + Name +
                       "\nBranch : " + BankType +
                       "\nIFSC Code : " + IFSCCode +
                       "\nCustomer Count : " + CustomerCount +
                       "\nInterest Rate On Savings : " + InterestRate;
            }
        }
        public enum Type
        {
            Public,
            Private,
            Commercial
        }
    }
