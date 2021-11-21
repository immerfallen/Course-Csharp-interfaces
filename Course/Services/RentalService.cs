using Course.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Services
{
    class RentalService
    {
        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        public void ProcessInvoice(CarRental carRental)
        {

        }


    }
}
