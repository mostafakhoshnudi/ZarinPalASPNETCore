using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Zarinpal.Models;

namespace Zarinpal
{
    public class Get
    {
        private readonly string _merchantId;

        public Get(string merchantId)
        {
            this._merchantId = merchantId;
        }
        public async Task<UnverifiedTransactionsResponse> UnverifiedTransactions()
        {
            var k = await Client.Create().GetUnverifiedTransactionsAsync(this._merchantId);
            UnverifiedTransactionsResponse obj = new UnverifiedTransactionsResponse();
            obj.Authorities = k.Body.Authorities;
            obj.Status = k.Body.Status;            
            return obj;

            //using (HttpClient httpClient = new HttpClient())
            //{
            //    using (HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("http://api3.zarinpal.dev/pg/rest/WebGate/GetUnverifiedTransactions.json", (HttpContent)new StringContent(JsonConvert.SerializeObject((object)new
            //    {
            //        MerchantID = this._merchantId
            //    }), Encoding.UTF8, "application/json")))
            //    {
            //        return  JsonConvert.DeserializeObject<UnverifiedTransactionsResponse>(await httpResponseMessage.Content.ReadAsStringAsync());
            //    }
            //}
        }
    }
}
