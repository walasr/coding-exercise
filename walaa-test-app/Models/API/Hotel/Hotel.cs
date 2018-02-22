namespace Expedia.HotelsOffers.Models.API
{
    public class Hotel
    {
        public OfferDateRange offerDateRange { get; set; }
        public Destination Destination { get; set; }
        public HotelInfo HotelInfo { get; set; }
        public HotelPricingInfo HotelPricingInfo { get; set; }
        public HotelUrls HotelUrls { get; set; }
    }
}
