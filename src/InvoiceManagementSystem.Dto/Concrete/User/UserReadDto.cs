using Core.Dto;
using Core.Entities.Concrete;
using RezervationSystem.Entity.Concrete;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace RezervationSystem.Dto.Concrete
{
    public class UserReadDto : IReadDto
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TC { get; set; }
        public string Plate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
