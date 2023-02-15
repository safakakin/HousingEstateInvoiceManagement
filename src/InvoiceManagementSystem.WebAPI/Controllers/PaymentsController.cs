using Microsoft.AspNetCore.Mvc;
using RezervationSystem.Business.Services.Abstract;
using RezervationSystem.Dto.Concrete;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class PaymentsController : BaseController<Payment, PaymentWriteDto, PaymentReadDto>
    {
        public PaymentsController(IPaymentService baseService) : base(baseService)
        {
        }

        [HttpGet]
        public async Task<IActionResult> Get(int index, int size)
        {
            return await base.GetListAsync(index, size);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            return await base.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PaymentWriteDto paymentWriteDto)
        {
            return await base.AddAsync(paymentWriteDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] PaymentWriteDto paymentWriteDto)
        {
            return await base.UpdateAsync(id, paymentWriteDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return await base.DeleteAsync(id);
        }
    }
}