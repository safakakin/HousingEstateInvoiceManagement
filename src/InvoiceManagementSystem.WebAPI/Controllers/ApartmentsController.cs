using Microsoft.AspNetCore.Mvc;
using RezervationSystem.Business.Services.Abstract;
using RezervationSystem.Dto.Concrete;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ApartmentsController : BaseController<Apartment, ApartmentWriteDto, ApartmentReadDto>
    {
        private readonly IApartmentService _service;
        public ApartmentsController(IApartmentService baseService) : base(baseService)
        {
            _service = baseService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int index, int size)
        {
            return await base.GetListAsync(index, size);
        }

        [HttpGet("ApartmentsDebts")]
        public async Task<IActionResult> ApartmentsDebtsReadDtosAsync()
        {
            return Ok(await _service.ApartmentsDebtsReadDtosAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            return await base.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ApartmentWriteDto apartmentWriteDto)
        {
            return await base.AddAsync(apartmentWriteDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] ApartmentWriteDto apartmentWriteDto)
        {
            return await base.UpdateAsync(id, apartmentWriteDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return await base.DeleteAsync(id);
        }        
    }
}