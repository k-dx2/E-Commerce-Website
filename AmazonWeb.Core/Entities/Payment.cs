using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonWeb.Core.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public string PaymentMethod { get; set; }
        public double PaymentAmount { get; set; }
        public DateTime PaymentDateTime { get; set; }
        public bool PaymentStatus { get; set; }

    }
}
