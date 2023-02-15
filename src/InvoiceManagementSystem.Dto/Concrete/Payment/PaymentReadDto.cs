using Core.Dto;
using Core.Entities.Concrete;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.Dto.Concrete
{
    public class PaymentReadDto : IReadDto
    {
        public int Id { get; set; }
        public UserReadDto Customer { get; set; }
        public ApartmentReadDto Apartment { get; set; }
        public int Cost { get; set; }
    }
}
