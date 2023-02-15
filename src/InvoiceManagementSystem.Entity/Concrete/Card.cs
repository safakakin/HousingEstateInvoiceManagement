using Core.Entities.Concrete;
using Core.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace RezervationSystem.Entity.Concrete
{
    public class Card : BaseEntity
    {
        public int CardNumber { get; set; }
        public int CardPassword { get; set; }
        public int Balance { get; set; }
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public User Customer { get; set; }
    }
}