namespace Expedia.HotelsOffers.Models.API
{
    public class Destination
    {
        public int RegionID { get; set; }
        public int AssociatedMultiCityRegionId { get; set; }
        public string longName { get; set; }
        public string ShortName { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Tla { get; set; }
        public string NonLocalizedCity { get; set; }
    }
}
