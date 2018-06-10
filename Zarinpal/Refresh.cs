using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Zarinpal.Models;

namespace Zarinpal
{
    public class Refresh
    {
        private readonly string _merchantId;
        public Refresh(string merchantId)
        {
            this._merchantId = merchantId;
        }

        public async Task<RefreshAuthorityResponse> Authority(string authority, int expireIn)
        {
            var k = await Client.Create().RefreshAuthorityAsync(this._merchantId, authority, expireIn);
            RefreshAuthorityResponse obj = new RefreshAuthorityResponse();
            obj.Status = k.Body.Status;
            return obj;

            //using (HttpClient httpClient = new HttpClient())
            //{
            //    using (HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("https://www.zarinpal.com/pg/rest/WebGate/RefreshAuthority.json",
            //        new StringContent(JsonConvert.SerializeObject(new
            //        {
            //            MerchantID = this._merchantId,
            //            ExpireIn = expireIn,
            //            Authority = authority
            //        }), Encoding.UTF8, "application/json")))
            //    {
            //        return JsonConvert.DeserializeObject<RefreshAuthorityResponse>(await httpResponseMessage.Content.ReadAsStringAsync());
            //    }
            //}
        }
    }
}
