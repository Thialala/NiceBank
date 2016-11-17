namespace NiceBank
{
    public class Account
    {
        private Money _balance = new Money();


        public void Credit(Money amount)
        {
            _balance = _balance.Add(amount);
        }

        public Money Balance => _balance;

        public void Debit(int dollars)
        {
            _balance = _balance.Minus(new Money(dollars, 0));
        }
    }
}