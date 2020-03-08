using DTO;
using InterfaceBrokerIntegrationLibrary;
using System;
using System.Collections.Generic;

namespace TinkoffIntegrationLibrary
{
    public class TBClass : IBroker
    {
        public IList<Course> A()
        {
            return new List<Course>()
            {
                new Course(){Name = "slkdjgbf"},
            };
        }
    }
}
