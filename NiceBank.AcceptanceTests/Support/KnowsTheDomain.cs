namespace NiceBank.AcceptanceTests.Support
{
    public class KnowsTheDomain
    {
        private Account _myAccount;
        private CashSlot _cashSlot;
        private Teller _teller;

        public Account MyAccount => _myAccount ?? (_myAccount = new Account());
        public CashSlot CashSlot => _cashSlot ?? (_cashSlot = new CashSlot());
        public Teller Teller => _teller ?? (_teller = new Teller(CashSlot));
    }
}