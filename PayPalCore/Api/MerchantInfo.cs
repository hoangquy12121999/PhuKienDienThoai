//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;

namespace PayPal.Api
{
    /// <summary>
    /// Merchant information for an invoice.
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class MerchantInfo : PayPalSerializableObject
    {
        /// <summary>
        /// Email address of the merchant. 260 characters max.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email")]
        public string email { get; set; }

        /// <summary>
        /// First name of the merchant. 30 characters max.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "first_name")]
        public string first_name { get; set; }

        /// <summary>
        /// Last name of the merchant. 30 characters max.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "last_name")]
        public string last_name { get; set; }

        /// <summary>
        /// Address of the merchant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "address")]
        public InvoiceAddress address { get; set; }

        /// <summary>
        /// Company business name of the merchant. 100 characters max.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "business_name")]
        public string business_name { get; set; }

        /// <summary>
        /// Phone number of the merchant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "phone")]
        public Phone phone { get; set; }

        /// <summary>
        /// Fax number of the merchant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fax")]
        public Phone fax { get; set; }

        /// <summary>
        /// Website of the merchant. 2048 characters max.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "website")]
        public string website { get; set; }

        /// <summary>
        /// Tax ID of the merchant. 100 characters max.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tax_id")]
        public string tax_id { get; set; }

        /// <summary>
        /// Option to display additional information such as business hours. 40 characters max.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "additional_info")]
        public string additional_info { get; set; }
    }
}
