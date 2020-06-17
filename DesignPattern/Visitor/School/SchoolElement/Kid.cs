﻿using System;
using System.Collections.Generic;
using System.Text;
using Visitor.School.Enum;
using Visitor.School.SchoolVisitor;

namespace Visitor.School.SchoolElement
{
    public class Kid : IElementSchool
    {
        public string Name { get; set; }

        private MedicineType _medicineType;
        private GiftType _giftType;

        public Kid( string name )
        {
            Name = name;
        }

        public void Accept( IVisitorSchool visitor )
        {
            visitor.Visit( this );
        }

        public MedicineType GetMedicine()
        {
            return _medicineType;
        }

        public GiftType GetGift()
        {
            return _giftType;
        }

        public void GivingMedication( MedicineType medicineType )
        {
            _medicineType = medicineType;
        }

        public void GivingGift( GiftType giftType )
        {
            _giftType = giftType;
        }
    }
}
