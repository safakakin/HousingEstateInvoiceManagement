using Core.Dto;

namespace RezervationSystem.Dto.Concrete
{
    public class PaymentWriteDto : IWriteDto
    {
        public int CustomerID { get; set; }
        public int ApartmentID { get; set; }
        public int Cost { get; set; }
        public int CardNumber { get; set; }
        public int? CardId { get; set; }
        public int Password { get; set; }
    }
}
