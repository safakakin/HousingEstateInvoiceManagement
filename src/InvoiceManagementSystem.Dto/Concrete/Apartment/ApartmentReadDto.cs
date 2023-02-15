using Core.Dto;

namespace RezervationSystem.Dto.Concrete
{
    public class ApartmentReadDto : IReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BlockReadDto Block { get; set; }
        public bool IsEmpty { get; set; }
        public StyleReadDto Style { get; set; }
        public int Floor { get; set; }       
        public UserReadDto Customer { get; set; }
    }
}
