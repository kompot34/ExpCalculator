namespace ExpCalculator.Entities
{
    public class Operation
    {
        public int ID { get; set; }
        public double Amount { get; set; }
        public virtual BankAcc BankAcc { get; set; }
        public int BankAccId { get; set; }
    }
}
