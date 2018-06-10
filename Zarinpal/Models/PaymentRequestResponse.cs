using System;
using System.Collections.Generic;
using System.Text;

namespace Zarinpal.Models
{
    public class PaymentRequestResponse
    {
        public int Status { get; set; }

        public string Authority { get; set; }

        public string Link =>
            $"https://www.zarinpal.com/pg/StartPay/{this.Authority}";
    }
}
