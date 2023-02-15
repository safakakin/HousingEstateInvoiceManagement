using Core.Dto;

namespace RezervationSystem.Dto.Concrete
{
    public class StyleReadDto : IReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
