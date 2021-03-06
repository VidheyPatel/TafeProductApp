﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;
        private decimal totalcharge;
        private decimal wrapcharge;
        private decimal GSTcharge;

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }

        public decimal Totalcharge
        {
            get { return totalcharge; }
            set { totalcharge = value; }
        }

        public decimal WrapCharge
        {
            get { return wrapcharge; }
            set { wrapcharge = value; }
        }

        public decimal GSTCharge
        {
            get { return GSTcharge; }
            set { GSTcharge = value; }
        }


        private decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }

        public void calTotalCharge()
        {
            totalcharge = TotalPayment + 25.00m;
            wrapcharge = TotalPayment + 25.00m + 5.00m;
            GSTcharge = (TotalPayment + 25.00m + 5.00m) * 1.1m;
        }
    }
}
