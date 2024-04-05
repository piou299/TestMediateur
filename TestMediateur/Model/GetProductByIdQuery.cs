using MediatR;

namespace TestMediateur.Model
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        private int id;

        public GetProductByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
