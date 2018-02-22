using Expedia.HotelsOffers.Models;
using Expedia.HotelsOffers.Models.API;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Expedia.HotelsOffers.Integration
{
    public class HotelService : IHotelService
    {
        #region Constants

        #region Path Constant parameters
        /// <summary>
        /// Constant parameters that in other situation should be handeled in differnt way
        /// </summary>
        const string SearchApiPath = "https://offersvc.expedia.com/offers/v2/getOffers";
        const string Scenario = "scenario";
        const string DealFinder = "deal-finder";
        const string Page = "page";
        const string Uid = "uid";
        const string Foo = "foo";
        const string ProductType = "productType";
        const string Hotel = "Hotel";
        #endregion

        #region Parameters Keys
        /// <summary>
        /// Query string Keys
        /// </summary>
        const string DestinationName = "destinationName";
        const string MinTripStartDate = "minTripStartDate";
        const string MaxTripStartDate = "maxTripStartDate";
        const string LengthOfStay = "lengthOfStay";
        const string MinGuestRating = "minGuestRating";
        const string MaxGuestRating = "maxGuestRating";
        const string MinStarRating = "minStarRating";
        const string MaxStarRating = "maxStarRating";
        const string MinTotalRate = "minTotalRate";
        const string MaxTotalRate = "maxTotalRate";
        #endregion

        #endregion

        #region Methods
        /// <summary>
        /// Call Search API
        /// </summary>
        /// <param name="criteria">Search criteria</param>
        /// <returns>List of offers</returns>
        public async Task<ApiResult> SearchDeals(Criteria criteria)
        {
            HttpClient client = new HttpClient();
            string apiUri = QueryHelpers.AddQueryString(SearchApiPath, GetDictionary(criteria));
            HttpResponseMessage response = await client.GetAsync(apiUri);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<ApiResult>();
            }
            else
            {
                throw new Exception("Oooops Somthing went wrong");
            }
        }

        /// <summary>
        /// create key value pairs of queryString key name and value
        /// </summary>
        /// <param name="criteria">Search criteria</param>
        /// <returns>Dictionary of key value</returns>
        private Dictionary<string, string> GetDictionary(Criteria criteria)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add(Scenario, DealFinder);
            dictionary.Add(Page, Foo);
            dictionary.Add(Uid, Foo);
            dictionary.Add(ProductType, Hotel);
            if (criteria.Destination != null)
            {
                dictionary.Add(DestinationName, Uri.EscapeDataString(criteria.Destination));
            }
            if (criteria.MinTripStartDate != null)
            {
                dictionary.Add(MinTripStartDate, criteria.MinTripStartDate.Value.ToFormatedDate());
            }
            if (criteria.MaxTripStartDate != null)
            {
                dictionary.Add(MaxTripStartDate, criteria.MaxTripStartDate.Value.ToFormatedDate());
            }
            if (criteria.LengthOfStay != null)
            {
                dictionary.Add(LengthOfStay, criteria.LengthOfStay.ToString());
            }
            if (criteria.MinGuestRating != null)
            {
                dictionary.Add(MinGuestRating, criteria.MinGuestRating.ToString());
            }
            if (criteria.MaxGuestRating != null)
            {
                dictionary.Add(MaxGuestRating, criteria.MaxGuestRating.ToString());
            }
            if (criteria.MinStarRating != null)
            {
                dictionary.Add(MinStarRating, criteria.MinStarRating.ToString());
            }
            if (criteria.MaxStarRating != null)
            {
                dictionary.Add(MaxStarRating, criteria.MaxStarRating.ToString());
            }
            if (criteria.MinTotalRate != null)
            {
                dictionary.Add(MinTotalRate, criteria.MinTotalRate.ToString());
            }
            if (criteria.MaxTotalRate != null)
            {
                dictionary.Add(MaxTotalRate, criteria.MaxTotalRate.ToString());
            }
            return dictionary;
        }
        #endregion
    }
}
