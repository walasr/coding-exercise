using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expedia.HotelsOffers
{
    public static class Extentions
    {
        private const string DateFormate = "yyyy-MM-dd";
        public static string ToFormatedDate(this DateTime date)
        {
            return date.ToString(DateFormate);
        }
        public static string CreateDateString(this List<int> list)
        {
            DateTime date = new DateTime(list[0], list[1], list[2]);
            return date.ToString(DateFormate);
        }
    }
}
