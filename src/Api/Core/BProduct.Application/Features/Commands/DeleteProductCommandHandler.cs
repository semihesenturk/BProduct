using BProduct.Application.Interfaces.Repositories;
using BProduct.Common.Models.RequestModels;
using MediatR;

namespace BProduct.Application.Features.Commands
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        #region Variables
        private readonly IProductRepository _productRepository;
        #endregion

        #region MyRegion
        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        #endregion

        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var result = await _productRepository.DeleteAsync(request.Id);

            if (result == 0)
                return false;

            return true;
        }
    }
}
