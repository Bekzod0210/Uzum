using MediatR;
using Uzum.Aplication.Abstractions;

namespace Uzum.Aplication.UseCase.Merchants.Commands
{
    public class AddProductToMerchantCommand : ICommand<Unit>
    {
        public int MerchantId { get; set; }
        public int ProductId { get; set; }

        public double Price { get; set; }
        public int Count { get; set; }
    }
}
