using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorInjection
{
    class MethodInjectionClient
    {
        public void Start(IService service)
            {
                service.Serve();
            }
        
    }
}
