using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Expedia.HotelsOffers.Models
{
    public class Criteria
    {
        [DisplayName("Destination")]
        public string Destination { get; set; }
        [DisplayName("Start Date Between")]
        public DateTime? MinTripStartDate { get; set; }
        [DisplayName("And")]
        public DateTime? MaxTripStartDate { get; set; }
        [DisplayName("Duration in Days")]
        public int? LengthOfStay { get; set; }
        [DisplayName("Hotel Star Rate Between")]
        public float? MinStarRating { get; set; }
        [DisplayName("And")]
        public float? MaxStarRating { get; set; }
        [DisplayName("Total Number of Reviews Between")]
        public float? MinTotalRate { get; set; }
        [DisplayName("And")]
        public float? MaxTotalRate { get; set; }
        [DisplayName("Guest Rating Between")]
        public float? MinGuestRating { get; set; }
        [DisplayName("And")]
        public float? MaxGuestRating { get; set; }
    }
}
