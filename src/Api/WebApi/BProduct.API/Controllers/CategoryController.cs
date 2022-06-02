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
        private readonly ILogger<CategoryController> _logger;
        #endregion

        #region Constructor
        public CategoryController(IMediator mediator, ILogger<CategoryController> logger)
        {
            _mediator = mediator;
            _logger = logger;
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
            {
                _logger.LogError($"Category can not be found!");
                return NotFound();
            }

            return Ok(result);
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryCommand command)
        {
            var result = await _mediator.Send(command);

            if (result == Guid.Empty)
            {
                _logger.LogError($"Category can not be created!");
                return BadRequest(result);
            }

            return Ok(result);
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpPut]
        public async Task<IActionResult> UpdateCategory([FromBody] UpdateCategoryCommand command)
        {
            var result = await _mediator.Send(command);

            if (result == Guid.Empty)
            {
                _logger.LogError($"Category can not be updated!");
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            DeleteCategoryCommand command = new DeleteCategoryCommand(id);

            var result = await _mediator.Send(command);

            if (!result)
            {
                _logger.LogError($"Category can not be deleted!");
                return BadRequest(result);
            }

            return Ok(result);
        }
        #endregion
    }
}
