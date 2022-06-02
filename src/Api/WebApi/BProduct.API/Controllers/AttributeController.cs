﻿using BProduct.Application.Features.Queries;
using BProduct.Common.Models.RequestModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BProduct.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributeController : BaseController
    {
        #region Variables
        private readonly IMediator _mediator;
        #endregion

        #region Constructor
        public AttributeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        #region Operations
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpGet]
        [Route("GetCategoryAttributes")]
        public async Task<IActionResult> GetCategoryAttributes([FromQuery] GetCategoryAttributesQuery query)
        {
            var result = await _mediator.Send(query);

            if (result.Count == 0)
                return NotFound();

            return Ok(result);
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpPost]
        [Route("AddCategoryAttribute")]
        public async Task<IActionResult> AddCategoryAttribute([FromBody] CreateCategoryAttributeCommand command)
        {
            var result = await _mediator.Send(command);

            if (result == Guid.Empty)
                return NotFound();

            return Ok(result);
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpGet]
        [Route("GetProductAttributes")]
        public async Task<IActionResult> GetProductAttributes([FromQuery] GetProductAttributesQuery query)
        {
            var result = await _mediator.Send(query);

            if (result.Count == 0)
                return NotFound();

            return Ok(result);
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpPost]
        [Route("AddProductAttribute")]
        public async Task<IActionResult> AddProductAttribute([FromBody] CreateProductAttributeCommand command)
        {
            var result = await _mediator.Send(command);
            if (result == Guid.Empty)
                return NotFound();

            return Ok(result);
        }
        #endregion
    }
}