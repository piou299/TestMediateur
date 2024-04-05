using MediatR;
using Microsoft.EntityFrameworkCore;

namespace TestMediateur.Model
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, Product>
    {
        private readonly IProductsRepo _productsRepo;

        public AddProductHandler(IProductsRepo productsRepo)
        {
            _productsRepo = productsRepo;
        }

        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var dto = request.DtoProduitAAjouter;
            Product produitAAjoutter = new Product
            {
                Quantity = dto.Quantity,
                Title = dto.Title
            };
            await _productsRepo.Products.AddAsync(produitAAjoutter);
            _productsRepo.SaveChanges();

            return produitAAjoutter;
        }
    }
}
