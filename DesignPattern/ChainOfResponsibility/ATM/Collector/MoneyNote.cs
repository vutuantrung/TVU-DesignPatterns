﻿using ChainOfResponsibility.ATM.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ATM.Collector
{
    public class MoneyNote
    {
        public MoneyNoteDenomination Type { get; set; }

        public int Count { get; set; }
    }
}
