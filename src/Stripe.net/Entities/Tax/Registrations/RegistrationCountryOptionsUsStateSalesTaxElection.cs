// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class RegistrationCountryOptionsUsStateSalesTaxElection : StripeEntity<RegistrationCountryOptionsUsStateSalesTaxElection>
    {
        /// <summary>
        /// A <a href="https://www.census.gov/library/reference/code-lists/ansi.html">FIPS code</a>
        /// representing the local jurisdiction.
        /// </summary>
        [JsonProperty("jurisdiction")]
        public string Jurisdiction { get; set; }

        /// <summary>
        /// The type of the election for the state sales tax registration.
        /// One of: <c>local_use_tax</c>, <c>simplified_sellers_use_tax</c>, or
        /// <c>single_local_use_tax</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}