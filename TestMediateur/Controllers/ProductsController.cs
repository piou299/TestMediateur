using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestMediateur.Model;

namespace TestMediateur.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ISender _mediator;

        public ProductsController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("List")]
        public async Task<IActionResult> GetAll()
        {
            var products = await _mediator.Send(new GetAllProductsQuery());
            return Ok(products);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(AddProduitDto produit)
        {
            var command = new AddProductCommand
            {
                DtoProduitAAjouter = produit
            };

           var response =  await _mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _mediator.Send(new GetProductByIdQuery(id));
            return product != null ? Ok(product) : NotFound();
        }
    }
}
