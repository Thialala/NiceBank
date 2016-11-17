using NiceBank.AcceptanceTests.Support;
using TechTalk.SpecFlow;

namespace NiceBank.AcceptanceTests
{
    [Binding]
    public class TellerSteps
    {
        private readonly KnowsTheDomain _helper;

        public TellerSteps(KnowsTheDomain helper)
        {
            _helper = helper;
        }

        [When(@"I request \$(.*)")]
        public void WhenIRequest(int dollars)
        {
            _helper.MyAccount.Debit(dollars);
            _helper.Teller.WithdrawFrom(_helper.MyAccount, dollars);
        }
    }
}
