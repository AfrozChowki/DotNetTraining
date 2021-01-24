using System;

namespace ConstructorInjection
{

    class Program
    {
        static void Main(string[] args)
        {
            #region ConstructorInjection


            //creating object
            IService s1 = new Service1();
            //passing dependency
            Client c1 = new Client(s1);
            c1.ServeMethod();

            var s2 = new Service2();
            //passing dependency
            c1 = new Client(s2);
            c1.ServeMethod();

            #endregion

            #region MethodInjection

            var client3 = new MethodInjectionClient();
            client3.Start(s1);
            client3.Start(s2);

            #endregion

            #region PropertyInjection

            var client4 = new PropertyInjectionClient();
            client4.Service=s1;
            client4.ServeMethod();

            #endregion
        }
    }
}
