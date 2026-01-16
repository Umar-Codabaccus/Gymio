using Gymio.Api.Domain.Primitives;
using Gymio.Api.Enums;

namespace Gymio.Api.Domain.Entities
{
    public sealed class Payment : Entity<Guid>
    {
        private Payment(Guid paymentId, Guid clientId, Guid gymId, decimal amount, PaymentMethod paymentMethod, string invoiceNumber, string note) : base(paymentId)
        {
            ClientId = clientId;
            GymId = gymId;
            Amount = amount;
            PaymentMethod = paymentMethod;
            InvoiceNumber = invoiceNumber;
            Note = note;
            Month = (Month) DateTime.UtcNow.Month;
            Year = DateTime.UtcNow.Year;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public Guid ClientId { get; private set; }
        public Client? Client { get; private set; }
        public Guid GymId { get; private set; }
        public Gym? Gym { get; private set; }
        
        public decimal Amount { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }
        public DateTime PaymentDate { get; private set; }
        public string InvoiceNumber { get; private set; } = string.Empty;
        public string? Note { get; private set; }
        public Month Month { get; private set; }
        public int Year { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public static Payment? Create(Guid clientId, Guid gymId, decimal amount, PaymentMethod paymentMethod, string invoiceNumber, string note)
        {
            var paymentId = Guid.NewGuid();
            var payment = new Payment(paymentId, clientId, gymId, amount, paymentMethod, invoiceNumber, note);
            return payment;
        }
    }
}
