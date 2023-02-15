
using RezervationSystem.Dto.Concrete;
using RezervationSystem.Entity.Concrete;

namespace InvoiceManagementSystem.Dto.Concrete.ApartmansDebts
{
    public class ApartmentsDebtsReadDto
    {
        public ApartmentReadDto Apartment { get; set; }
        public List<DebtReadDto> Debt { get; set; }
        public List<PaymentReadDto> Payment { get; set; }
        public double TotalDebt { get; set; }
    }
}
