using Core.Entities.Concrete;
using Core.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace RezervationSystem.Entity.Concrete
{
    public class Apartment : BaseEntity
    {
        [NotMapped]
        public string Name
        {
            get
            {
                return $"{Block?.Name} -> Floor:{Floor} -> Style:{Style?.Name}";
            }
        }
        public int BlockID { get; set; }
        [ForeignKey("BlockID")]
        public Block Block { get; set; }
        public bool IsEmpty { get; set; } = true;
        public int StyleID { get; set; }
        [ForeignKey("StyleID")]
        public Style Style { get; set; }
        public int Floor { get; set; }
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public User Customer { get; set; }
    }
}
