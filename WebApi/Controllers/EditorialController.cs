using Application.Dtos.Editoriales;
using Application.Services.Abstractions;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditorialController : Controller
    {
        private readonly IEditorialService _editorialService;

        public EditorialController(IEditorialService editorialService)
        {
            _editorialService = editorialService;
        }

        [HttpGet]
        public async Task<IEnumerable<EditorialDto>> Get()
        => await _editorialService.FindAll();

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(EditorialDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<Results<NotFound, Ok<EditorialDto>>> Get(int id)
        {
            var response = await _editorialService.Find(id);
            if (response == null) return TypedResults.NotFound();

            return TypedResults.Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(EditorialDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Results<BadRequest, Ok<EditorialDto>>> Post(EditorialFormDto request)
        { 
            var response = await _editorialService.Create(request);
            if (response == null) return TypedResults.BadRequest();

            return TypedResults.Ok(response);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(EditorialDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<Results<BadRequest, NotFound, Ok<EditorialDto>>> Put(int id, [FromBody] EditorialFormDto request)
        {
            var response = await _editorialService.Edit(id, request);
            if (response == null) return TypedResults.NotFound();

            return TypedResults.Ok(response);
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(EditorialDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<Results<NotFound, Ok<EditorialDto>>> Detele(int id)
        {
            var response = await _editorialService.EnabledOrDisabled(id);
            if (response == null) return TypedResults.NotFound();

            return TypedResults.Ok(response);
        }
    }
}
