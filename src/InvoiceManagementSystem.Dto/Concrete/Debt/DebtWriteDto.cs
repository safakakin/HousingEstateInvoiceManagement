using Core.Dto;
using Core.Entities.Concrete;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.Dto.Concrete
{
    public class DebtWriteDto : IWriteDto
    {
        public int CustomerID { get; set; }
        public int ApartmentID { get; set; }
        public int Cost { get; set; }
    }
}
