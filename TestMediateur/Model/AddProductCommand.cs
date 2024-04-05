using MediatR;

namespace TestMediateur.Model
{
    public class AddProductCommand : IRequest<Product>
    {
        public AddProduitDto DtoProduitAAjouter { get; set; }
    }
}
