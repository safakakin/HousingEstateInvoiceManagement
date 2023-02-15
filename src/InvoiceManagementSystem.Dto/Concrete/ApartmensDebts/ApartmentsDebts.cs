
using RezervationSystem.Dto.Concrete;
using RezervationSystem.Entity.Concrete;

namespace InvoiceManagementSystem.Dto.Concrete.ApartmansDebts
{
    public class ApartmentsDebts
    {
        public Apartment Apartment { get; set; }
        public List<Debt> Debt { get; set; }
        public List<Payment> Payment { get; set; } 
        public double TotalDebt { get; set; }
    }
}
