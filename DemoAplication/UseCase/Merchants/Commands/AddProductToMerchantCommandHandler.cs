using MediatR;
using Microsoft.EntityFrameworkCore;
using Uzum.Aplication.Abstractions;
using Uzum.Aplication.Exceptions;
using Uzum.Domain.Entities;

namespace Uzum.Aplication.UseCase.Merchants.Commands
{
    public class AddProductToMerchantCommandHandler : ICommandHandler<AddProductToMerchantCommand, Unit>
    {
        private readonly IAppDbContext _appDbContext;
        public AddProductToMerchantCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Unit> Handle(AddProductToMerchantCommand request, CancellationToken cancellationToken)
        {
            var product = await _appDbContext.Products.FirstOrDefaultAsync(x => x.Id == request.ProductId, cancellationToken);
            var merchant = await _appDbContext.Merchants.FirstOrDefaultAsync(x => x.Id == request.MerchantId, cancellationToken);
            var merchantProduct = await _appDbContext.MerchantProducts.FirstOrDefaultAsync(c => c.MerchantId == request.MerchantId
                && c.ProductId == request.ProductId, cancellationToken);

            if (product == null)
            {
                throw new ProductException();
            }
            if (merchant == null)
            {
                throw new MerchantException();
            }

            //Bu yerda tekshirish mantiqsiz
            //if (merchantProduct == null)
            //{

            //}
            var merchantProducts = new MerchantProduct
            {
                MerchantId = merchantProduct!.MerchantId,
                ProductId = merchantProduct.ProductId,
                Price = merchantProduct.Price,
                Count = merchantProduct.Count,
            };


            // nimaga bunday yozilganligini soriman ustozdan
            await _appDbContext.MerchantProducts.AddAsync(merchantProducts, cancellationToken);

            await _appDbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
}
