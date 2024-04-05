using MediatR;

namespace TestMediateur.Model
{
    public class GetAllProductsQuery : IRequest<List<Product>>
    {
    }
}
