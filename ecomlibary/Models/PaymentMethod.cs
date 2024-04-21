using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecomlibary.Models
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string CardholderName { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }
        public string CVV { get; set; }
    }
}
