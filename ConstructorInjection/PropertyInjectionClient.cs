using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorInjection
{
    class PropertyInjectionClient
    {
        private IService _service;
        public IService Service
        {
            set { this._service = value; }
        }
        public void ServeMethod() { this._service.Serve(); }
    }
}
