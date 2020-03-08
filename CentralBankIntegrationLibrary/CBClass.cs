using DTO;
using InterfaceBrokerIntegrationLibrary;
using System;
using System.Collections.Generic;

namespace CentralBankIntegrationLibrary
{
    public class CBClass : IBroker
    { 
        public IList<Course> A()
        {
            return new List<Course> { new Course
            {
                Name = "душкцпи"
            } };
        }
    }
}
