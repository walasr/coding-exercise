namespace Expedia.HotelsOffers.Models.API
{
    public class ApiResult
    {
        public OfferInfo OfferInfo { get; set; }
        public UserInfo UserInfo { get; set; }
        public Offers Offers { get; set; }
    }
}
