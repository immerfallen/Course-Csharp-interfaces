﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Services
{
    class BrazilTaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
