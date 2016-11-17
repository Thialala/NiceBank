namespace NiceBank
{
    public class CashSlot
    {
        private int _contents;

        public int GetContents()
        {
            return _contents;
        }

        public void Dispense(int amount)
        {
            _contents = amount;
        }
    }
}