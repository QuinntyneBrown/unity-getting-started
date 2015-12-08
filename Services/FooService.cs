using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using unity_getting_started.Services.Contracts;

namespace unity_getting_started.Services
{
    public class FooService: IFooService
    {
        public string Foo()
        {
            return "Unity Getting Started";
        }
    }
}