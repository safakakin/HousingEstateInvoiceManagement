using Core.Dto;
using Core.Entities.Concrete;
using RezervationSystem.Entity.Concrete;
using System.ComponentModel.DataAnnotations.Schema;

namespace RezervationSystem.Dto.Concrete
{
    public class MessageReadDto : IReadDto
    {
        public int Id { get; set; }
        public UserReadDto Customer { get; set; }
        public string WrotenMessage { get; set; }
    }
}
