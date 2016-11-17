namespace NiceBank
{
    public class Money
    {
        public int Dollars { get; }

        public int Cents { get; }

        public Money()
        {
            Dollars = 0;
            Cents = 0;
        }

        public Money(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
        }

        public Money Add(Money amount)
        {
            var newCents = Cents + amount.Cents;
            var newDollars = Dollars + amount.Dollars;

            if (newCents >= 100)
            {
                newCents -= 100;
                newDollars++;
            }

            return new Money(newDollars, newCents);
        }

        public Money Minus(Money amount)
        {
            int newCents = Cents - amount.Cents;
            int newDollars = Dollars - amount.Dollars;

            if (newCents < 0)
            {
                newCents += 100;
                newDollars--;
            }

            return new Money(newDollars, newCents);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((Money)obj);
        }

        protected bool Equals(Money other)
        {
            return Dollars == other.Dollars && Cents == other.Cents;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Dollars * 397) ^ Cents;
            }
        }

        public override string ToString()
        {
            return $"{Dollars}.{Cents}";
        }
    }
}
