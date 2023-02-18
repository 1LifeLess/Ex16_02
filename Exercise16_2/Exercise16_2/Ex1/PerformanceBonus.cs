namespace Exercise16_2.Ex1
{
    public class PerformanceBonus : ExtraPayment
    {
        public bool WasPayed { get; set; }

        public PerformanceBonus(int amountToPay, string description)
        {
            AmountToPay = amountToPay;
            Description = description;
            WasPayed = false;
        }

    }
}
