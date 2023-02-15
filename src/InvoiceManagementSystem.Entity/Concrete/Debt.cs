using Core.Entities.Concrete;
using Core.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace RezervationSystem.Entity.Concrete
{
    public class Debt : BaseEntity
    {
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public User Customer { get; set; }
        public int ApartmentID { get; set; }
        [ForeignKey("ApartmentID")]
        public Apartment Apartment { get; set; }
        public int Cost { get; set; }
    }
}