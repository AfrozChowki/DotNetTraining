using System;
using System.Collections.Generic;
using System.Text;

namespace IoC_DIP_Demo
{
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }
    public class CustomerDataAccess : ICustomerDataAccess
    {
        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name";
        }
    }
    public class DataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerDataAccessObj()
        {
            return new CustomerDataAccess();
        }
    }

    #region DI Injection

    public class CustomerBusinessLogicDI
    {
        ICustomerDataAccess _dataAccess;

        public CustomerBusinessLogicDI(ICustomerDataAccess custDataAccess)
        {
            _dataAccess = custDataAccess;
        }

        public CustomerBusinessLogicDI()
        {
            _dataAccess = new CustomerDataAccess();
        }

        public string ProcessCustomerData(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }
    }

    #endregion
    public class CustomerBusinessLogic
    {
        ICustomerDataAccess _custDataAccess;

        public CustomerBusinessLogic()
        {
            _custDataAccess = DataAccessFactory.GetCustomerDataAccessObj();
        }

        public string GetCustomerName(int id)
        {
            return _custDataAccess.GetCustomerName(id);
        }
    }

    class OnlyPriniciples
    {
    }
}
