﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SGRP.Aliexpress.Bussiness.Models
{
    public class ShippingContentModel
    {
        [JsonProperty(PropertyName = "body")]
        public ShippingBody ShippingBody { get; set; }
    }

    public class ShippingBody
    {
        [JsonProperty(PropertyName = "freightResult")]
        public List<ShippingFreightResult> ShippingFreightResult { get; set; }
    }

    public class ShippingFreightResult
    {
        [JsonProperty(PropertyName = "commitDay")]
        public int CommitDay { get; set; }

        [JsonProperty(PropertyName = "company")]
        public string Company { get; set; }

        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

        [JsonProperty(PropertyName = "freightAmount")]
        public ShippingFreightAmount ShippingFreightAmount { get; set; }

        [JsonProperty(PropertyName = "tracking")]
        public bool Tracking { get; set; }
    }

    public class ShippingFreightAmount
    {
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "formatedAmount")]
        public string FormatedAmount { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }
    }

    public class VariationModel
    {
        public VariationEnums Id { get; set; }

        public string Value { get; set; }
        
    }

    public enum VariationEnums
    {
        Color = 1,
        Size = 2,
        ShipFrom = 3,
        Other = 4,
    }


}
