﻿using Course.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Services
{
    class RentalService
    {

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();
        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.00;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            } else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);

        }


    }
}
