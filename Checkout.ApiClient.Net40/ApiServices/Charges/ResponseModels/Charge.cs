using Checkout.ApiServices.Cards.ResponseModels;
using Checkout.ApiServices.Charges.RequestModels;
using Checkout.ApiServices.SharedModels;
using System;
using System.Collections.Generic;

namespace Checkout.ApiServices.Charges.ResponseModels
{
    public class Charge:BaseCharge
    {
        public string Id { get; set; }
        public bool LiveMode { get; set; }
        public string Created { get; set; }
        public int ChargeMode { get; set; }
        public string CustomerId { get; set; }
        public string TransactionIndicator { get; set; }
        public Card Card { get; set; }
        public string ResponseMessage { get; set; }
        public string ResponseAdvancedInfo { get; set; }
        public string ResponseCode { get; set; }
        public string Status { get; set; }
        public bool IsCascaded { get; set; }
        public string AuthCode { get; set; }
        public Address ShippingDetails { get; set; }
    }
}