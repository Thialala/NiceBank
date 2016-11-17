namespace NiceBank
{
    public class Teller
    {
        private readonly CashSlot _cashSlot;

        public Teller(CashSlot cashSlot)
        {
            _cashSlot = cashSlot;
        }

        public void WithdrawFrom(Account account, int amount)
        {
            _cashSlot.Dispense(amount);
        }
    }
}