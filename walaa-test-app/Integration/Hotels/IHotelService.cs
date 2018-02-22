using Expedia.HotelsOffers.Models;
using Expedia.HotelsOffers.Models.API;
using System.Threading.Tasks;

namespace Expedia.HotelsOffers.Integration
{
    public interface IHotelService
    {
        Task<ApiResult> SearchDeals(Criteria criteria);
    }
}
