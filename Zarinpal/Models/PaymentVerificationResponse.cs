using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zarinpal.Models
{
    
    public class PaymentVerificationResponse
    {
        public int Status { get; set; }

        [JsonProperty("RefID")]
        public long RefId { get; set; }
    }
}
