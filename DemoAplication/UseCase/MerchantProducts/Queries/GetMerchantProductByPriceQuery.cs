using Uzum.Aplication.Abstractions;
using Uzum.Domain.Entities;

namespace Uzum.Aplication.UseCase.MerchantProducts.Queries
{
    public class GetMerchantProductByPriceQuery : IQuery<List<MerchantProduct>>
    {
        public int Page { get; set; }

        public int Limit { get; set; }

        public GetMerchantProductByPriceQuery(int page, int limit)
        {
            Page = page;
            Limit = limit;
        }
    }
}