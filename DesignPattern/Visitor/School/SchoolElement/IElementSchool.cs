using System;
using System.Collections.Generic;
using System.Text;
using Visitor.School.Enum;
using Visitor.School.SchoolVisitor;

namespace Visitor.School.SchoolElement
{
    // This is an interface that defines an Accept operation that takes a visitor as an argument.
    public interface IElementSchool
    {
        // Define Accept method
        void Accept( IVisitorSchool visitor );
        void GivingMedication( MedicineType medicineType );
        void GivingGift( GiftType giftType );
        MedicineType GetMedicine();
        GiftType GetGift();
    }
}
