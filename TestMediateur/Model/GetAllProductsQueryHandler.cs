using MediatR;

namespace TestMediateur.Model
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
    {
        private readonly IProductsRepo _productsRepo;

        public GetAllProductsQueryHandler(IProductsRepo productsRepo)
        {
            _productsRepo = productsRepo;
        }

        public Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
