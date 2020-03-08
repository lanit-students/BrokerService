using CentralBankIntegrationLibrary;
using InterfaceBrokerIntegrationLibrary;
using System;
using TinkoffIntegrationLibrary;

namespace BrokerService.Controllers
{
    internal static class BrokerFactory
    {
        internal static IBroker CreateBroker(BankTypes bankType)
        {
            switch (bankType)
            {
                case (BankTypes.CentralBank) :
                    return new CBClass();
                case (BankTypes.TinkoffBank):
                    return new TBClass();                    
            }
            throw new Exception();
        }
    }
}