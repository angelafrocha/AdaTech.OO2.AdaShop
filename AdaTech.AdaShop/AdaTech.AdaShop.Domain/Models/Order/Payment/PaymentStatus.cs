﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.AdaShop.Domain.Models.Order.Payment
{
    public enum PaymentStatus
    {
        Pending = 0,
        Successful = 1,
        Failed = 2,
        Refunded = 3
    }
}
