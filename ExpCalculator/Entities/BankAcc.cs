namespace ExpCalculator.Entities
{
    public class BankAcc
    {
        public int Id { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public virtual Currency Currency { get; set; }
        public int CurrencyId { get; set; }
        public virtual List<Operation> Operations { get; set; }
    }
}
