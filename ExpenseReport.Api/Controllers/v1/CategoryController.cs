using ExpenseReport.API.Controllers;
using ExpenseReport.Application.Features.Brands.Commands.Create;
using ExpenseReport.Application.Features.Categories.Commands.Create;
using ExpenseReport.Application.Features.Categories.Commands.Delete;
using ExpenseReport.Application.Features.Categories.Commands.Update;
using ExpenseReport.Application.Features.Categories.Queries.GetAllCached;
using ExpenseReport.Application.Features.Categories.Queries.GetById;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExpenseReport.Api.Controllers.v1
{
    public class CategoryController : BaseApiController<CategoryController>
    {
        [HttpGet]
        public async Task<IActionResult> GetAll(int pageNumber, int pageSize)
        {
            var categories = await _mediator.Send(new GetAllCategoriesQuery(pageNumber, pageSize));
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var categoy = await _mediator.Send(new GetCategoryByIdQuery() { Id = id });
            return Ok(categoy);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(CreateCategoryCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UpdateCategoryCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await _mediator.Send(command));
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteCategoryCommand { Id = id }));
        }
    }
}