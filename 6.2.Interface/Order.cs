﻿using System;

namespace _6._2.Interface
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }
        public bool IsShipped
        {
            get { return Shipment != null; }
        }
    }
}