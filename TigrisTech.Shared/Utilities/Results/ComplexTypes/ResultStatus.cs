﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigrisTech.Shared.Utilities.Results.ComplexTypes
{
    public enum ResultStatus
    {
        Success=0,
        Error=1,
        Warning=2,
        Info=3,
        Authentication =4,
        Authorization =5,
    }
}