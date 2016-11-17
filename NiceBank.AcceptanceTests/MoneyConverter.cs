using TechTalk.SpecFlow;

namespace NiceBank.AcceptanceTests
{
    [Binding]
    public class MoneyConverter
    {
        [StepArgumentTransformation(@"\$(\d+).(\d+)")]
        public Money Transform(int dollars, int cents)
        {
            return new Money(dollars, cents);
        }
    }
}
