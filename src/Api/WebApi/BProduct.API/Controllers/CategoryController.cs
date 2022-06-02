using BProduct.Application.Features.Queries;
using BProduct.Common.Models.RequestModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BProduct.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseController
    {
        #region Variables
        private readonly IMediator _mediator;
        #endregion

        #region Constructor
        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        #region Operations
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpGet]
        public async Task<IActionResult> GetCategory(Guid id)
        {
            var result = await _mediator.Send(new GetCategoryQuery() { Id = id });

            if (result is null)
                return NotFound();

            return Ok(result);
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryCommand command)
        {
            var result = await _mediator.Send(command);

            if (result == Guid.Empty)
                return BadRequest(result);

            return Ok(result);
        }
        #endregion
    }
}
