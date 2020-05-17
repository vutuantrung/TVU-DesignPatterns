using FactoryMethod.CreditCard.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.CreditCard.Card
{
    public interface ICreditCard
    {
        CreditCardType GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
