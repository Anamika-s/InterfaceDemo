using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class Demo : IInterface1, IInterface2
    {
        public void Get()
        {
            throw new NotImplementedException();
        }

        void IInterface2.Display()
        {
            throw new NotImplementedException();
        }

        void IInterface2.Get()
        {
            throw new NotImplementedException();
        }
    }
}
