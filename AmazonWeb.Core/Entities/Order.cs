using System;
using System.Collections.Generic;
using System.Text;
using AmazonWeb.Core.Entities.Base;

namespace AmazonWeb.Core.Entities
{
    public class Order : Entity
    {
        public string UserName { get; set; }
        //public Address BilingAddress {get; set;}
        //public Address shippingAddress {get;set;}
        public PaymentMethod PaymentMethod { get; set; }
        public OrderStatus Status { get; set; }
        public decimal GrandTotal { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    
    }
    public class Address
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNo { get; set; }
        public string CompanyName { get; set; }
        public string AddressLine { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string  ZipCode { get; set; }
        
    }
    public enum OrderStatus
    {
        Progresss=1,
        OnShipping=2,
        Finished=3
    }
    public enum PaymentMethod
    {
        Check=1,
        BankTransfer=2,
        Cash=3,
        Paypal=4,
        Payoneer=5
    }
}

