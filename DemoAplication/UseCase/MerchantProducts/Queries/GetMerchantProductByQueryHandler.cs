using Microsoft.EntityFrameworkCore;
using Uzum.Aplication.Abstractions;
using Uzum.Domain.Entities;

namespace Uzum.Aplication.UseCase.MerchantProducts.Queries
{
    public class GetMerchantProductByQueryHandler : IQueryHandler<GetMerchantProductByPriceQuery, List<MerchantProduct>>
    {
        private readonly IAppDbContext _appDbContext;
        public GetMerchantProductByQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<MerchantProduct>> Handle(GetMerchantProductByPriceQuery request, CancellationToken cancellationToken)
        {
            var skip = request.Page > 0 ? (request.Page - 1) * request.Limit : 0;

            var merchantProducts = await _appDbContext.MerchantProducts
                .OrderBy(x => x.Id)
                .ThenBy(x => x.Price)
                .Skip(skip)
                .Take(request.Limit)
                .ToListAsync(cancellationToken);
            return merchantProducts;
        }
    }
}
