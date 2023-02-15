using Core.Dto;
using Core.Entities.Concrete;

namespace RezervationSystem.Dto.Concrete
{
    public class CardWriteDto : IWriteDto
    {
        public int CustomerID { get; set; }
        public int CardNumber { get; set; }
        public int CardPassword { get; set; }
        public int Balance { get; set; }
    }
}
