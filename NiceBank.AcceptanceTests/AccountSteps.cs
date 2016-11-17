using FluentAssertions;
using NiceBank.AcceptanceTests.Support;
using TechTalk.SpecFlow;

namespace NiceBank.AcceptanceTests
{
    [Binding]
    public class AccountSteps
    {
        private readonly KnowsTheDomain _helper;

        public AccountSteps(KnowsTheDomain helper)
        {
            _helper = helper;
        }

        [Given(@"my account has been credited with ""(.*)""")]
        public void GivenMyAccountHasBeenCreditedWith(Money amount)
        {
            _helper.MyAccount.Credit(amount);
        }

        [Then(@"the balance of my account should be ""(.*)""")]
        public void ThenTheBalanceOfMyAccountShouldBe(Money amount)
        {
            _helper.MyAccount.Balance.Should().Be(amount);
        }
    }
}
