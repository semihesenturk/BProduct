using BProduct.Application.Features.Queries;
using BProduct.Common.Models.RequestModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BProduct.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController
    {
        #region Variables
        private readonly IMediator _mediator;
        private readonly ILogger<ProductController> _logger;
        #endregion

        #region Constructor
        public ProductController(IMediator mediator, ILogger<ProductController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
        #endregion

        #region Operations
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpGet]
        public async Task<IActionResult> GetProduct(Guid id)
        {
            GetProductQuery query = new GetProductQuery(id);

            var result = await _mediator.Send(query);

            if (result is null)
            {
                _logger.LogError($"Product with id:{id} can not be found!");
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductCommand command)
        {
            var result = await _mediator.Send(command);

            if (result == Guid.Empty)
            {
                _logger.LogError("Product can not be saved!");
                return NotFound();
            }

            return Ok(result);
        }
        #endregion
    }
}
