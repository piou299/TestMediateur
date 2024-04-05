using MediatR;

namespace TestMediateur.Model
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        public Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
