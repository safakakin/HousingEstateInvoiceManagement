using Core.Dto;

namespace RezervationSystem.Dto.Concrete
{
    public class BlockReadDto : IReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
