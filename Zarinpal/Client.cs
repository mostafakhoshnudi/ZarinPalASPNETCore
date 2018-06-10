using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using ZarinpalService;

namespace Zarinpal
{
    internal class Client
    {
        internal static PaymentGatewayImplementationServicePortTypeClient Create()
        {
            EndpointAddress endpointAddress = new EndpointAddress("https://www.zarinpal.com/pg/services/WebGate/service");
            BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
            basicHttpBinding.Security.Mode = BasicHttpSecurityMode.Transport;
            return new PaymentGatewayImplementationServicePortTypeClient(basicHttpBinding, endpointAddress);
        }
    }
}
