using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zarinpal.Models
{
    public class PaymentVerificationWithExtraResponse
    {
        public int Status { get; set; }

        [JsonProperty("RefID")]
        public long RefId { get; set; }

        public string ExtraDetail { get; set; }
    }
}
