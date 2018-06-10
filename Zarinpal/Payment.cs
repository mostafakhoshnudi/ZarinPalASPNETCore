using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Zarinpal.Models;

namespace Zarinpal
{
    public class Payment
    {
        private readonly string _merchantId;
        private readonly int _amount;

        public Payment(string merchantId, int amount)
        {
            this._merchantId = merchantId;
            this._amount = amount;
        }

        public async Task<PaymentRequestResponse> PaymentRequest(string description, string callbackUrl, string email = null, string mobile = null)
        {
            var k = await Client.Create().PaymentRequestAsync(this._merchantId, this._amount, description, email, mobile, callbackUrl);
            PaymentRequestResponse obj = new PaymentRequestResponse();
            obj.Authority = k.Body.Authority;
            obj.Status = k.Body.Status;            
            return obj;
            //using (HttpClient httpClient = new HttpClient())
            //{
            //    using (HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("https://www.zarinpal.com/pg/rest/WebGate/PaymentRequest.json",
            //        new StringContent(JsonConvert.SerializeObject(new
            //        {
            //            MerchantID = this._merchantId,
            //            Amount = this._amount,
            //            Description = description,
            //            Email = email,
            //            Mobile = mobile,
            //            CallbackURL = callbackUrl
            //        }), Encoding.UTF8, "application/json")))
            //    {
            //        return JsonConvert.DeserializeObject<PaymentRequestResponse>(await httpResponseMessage.Content.ReadAsStringAsync());
            //    }
            //}
        }

        //public async Task<PaymentRequestResponse> UnverifiedTransactions()
        //{
        //    //var k = await Client.Create().(this._merchantId, this._amount, description, email, mobile, callbackUrl);
        //    using (HttpClient httpClient = new HttpClient())
        //    {
        //        using (HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("http://api3.zarinpal.dev/pg/rest/WebGate/UnverifiedTransactions.json",
        //            new StringContent(JsonConvert.SerializeObject(new
        //            {
        //                MerchantID = this._merchantId
        //            }), Encoding.UTF8, "application/json")))
        //        {
        //            return JsonConvert.DeserializeObject<PaymentRequestResponse>(await httpResponseMessage.Content.ReadAsStringAsync());
        //        }
        //    }
        //}

        public async Task<PaymentVerificationResponse> Verification(string authority)
        {
            var k = await Client.Create().PaymentVerificationAsync(this._merchantId, authority, this._amount);
            PaymentVerificationResponse obj = new PaymentVerificationResponse();
            obj.RefId = k.Body.RefID;
            obj.Status = k.Body.Status;            
            return obj;
            
            //using (HttpClient httpClient = new HttpClient())
            //{
            //    using (HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("http://api3.zarinpal.dev/pg/rest/WebGate/PaymentVerification.json",
            //        new StringContent(JsonConvert.SerializeObject(new
            //        {
            //            MerchantID = this._merchantId,
            //            Amount = this._amount,
            //            Authority = authority
            //        }), Encoding.UTF8, "application/json")))
            //    {
            //        return JsonConvert.DeserializeObject<PaymentVerificationResponse>(await httpResponseMessage.Content.ReadAsStringAsync());
            //    }
            //}
        }

        public async Task<PaymentRequestResponse> PaymentRequestWithExtra(string description, string additionalData, string callbackUrl, string email = null, string mobile = null)
        {
            var k = await Client.Create().PaymentRequestWithExtraAsync(this._merchantId, this._amount, description, additionalData, email, mobile, callbackUrl);
            PaymentRequestResponse obj = new PaymentRequestResponse();
            obj.Authority = k.Body.Authority;
            obj.Status = k.Body.Status;                  
            return obj;
            //using (HttpClient httpClient = new HttpClient())
            //{
            //    using (HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("https://www.zarinpal.com/pg/rest/WebGate/PaymentRequestWithExtra.json",
            //        new StringContent(JsonConvert.SerializeObject(new
            //        {
            //            MerchantID = this._merchantId,
            //            Amount = this._amount,
            //            Description = description,
            //            AdditionalData = additionalData,
            //            Email = email,
            //            Mobile = mobile,
            //            CallbackURL = callbackUrl
            //        }), Encoding.UTF8, "application/json")))
            //    {
            //        return JsonConvert.DeserializeObject<PaymentRequestResponse>(await httpResponseMessage.Content.ReadAsStringAsync());
            //    }
            //}
        }

        public async Task<PaymentVerificationWithExtraResponse> VerificationWithExtra(string authority)
        {
            var k = await Client.Create().PaymentVerificationWithExtraAsync(this._merchantId, authority, this._amount);
            PaymentVerificationWithExtraResponse obj = new PaymentVerificationWithExtraResponse();
            obj.RefId = k.Body.RefID;
            obj.Status = k.Body.Status;
            obj.ExtraDetail = k.Body.ExtraDetail;            
            return obj;

            //using (HttpClient httpClient = new HttpClient())
            //{
            //    using (HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("http://api3.zarinpal.dev/pg/rest/WebGate/PaymentVerificationWithExtra.json",
            //        new StringContent(JsonConvert.SerializeObject(new
            //        {
            //            MerchantID = this._merchantId,
            //            Amount = this._amount,
            //            Authority = authority
            //        }), Encoding.UTF8, "application/json")))
            //    {
            //        return JsonConvert.DeserializeObject<PaymentVerificationWithExtraResponse>(await httpResponseMessage.Content.ReadAsStringAsync());
            //    }
            //}

        }
    }
}
