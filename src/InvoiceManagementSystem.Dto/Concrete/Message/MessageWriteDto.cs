using Core.Dto;
using Core.Entities.Concrete;
using RezervationSystem.Entity.Concrete;
using System.ComponentModel.DataAnnotations.Schema;

namespace RezervationSystem.Dto.Concrete
{
    public class MessageWriteDto : IWriteDto
    {
        public int CustomerID { get; set; }
        public string WrotenMessage { get; set; }
    }
}
