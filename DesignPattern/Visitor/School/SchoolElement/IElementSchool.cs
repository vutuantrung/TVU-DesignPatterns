using System;
using System.Collections.Generic;
using System.Text;
using Visitor.School.Enum;
using Visitor.School.SchoolVisitor;

namespace Visitor.School.SchoolElement
{
    public interface IElementSchool
    {
        void Accept( IVisitorSchool visitor );
        void GivingMedication( MedicineType medicineType );
        void GivingGift( GiftType giftType );
        MedicineType GetMedicine();
        GiftType GetGift();
    }
}
