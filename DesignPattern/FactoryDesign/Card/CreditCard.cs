using FactoryDesign.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesign.Card
{
    public interface CreditCard
    {
        CreditCardType GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
