using FluentAssertions;
using NiceBank.AcceptanceTests.Support;
using TechTalk.SpecFlow;

namespace NiceBank.AcceptanceTests
{
    [Binding]
    public class CashSlotSteps
    {
        private readonly KnowsTheDomain _helper;

        public CashSlotSteps(KnowsTheDomain helper)
        {
            _helper = helper;
        }

        [Then(@"\$(.*) should be dispensed")]
        public void ThenShouldBeDispensed(int amount)
        {
            _helper.CashSlot.GetContents().Should().Be(amount);
        }
    }
}
