using Core.Dto;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.Dto.Concrete
{
    public class ApartmentWriteDto : IWriteDto
    {
        public int BlockID { get; set; }
        public int StyleID { get; set; }
        public int Floor { get; set; }
    }
}
