﻿namespace AdaTech.AdaShop.Domain.Models.Order
{
    public class InfoPayments
    {
        public string ID { get; private set; }
        public Customer Customer {  get; private set; }
        public OrderAggregate OrderAggregate { get; set; }

    }
}