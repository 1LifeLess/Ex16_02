namespace Exercise16_2.Ex1
{
    public class CommitionBonus : ExtraPayment
    {
        public readonly int CommitionPrecent;
        public readonly int DealProfit;
        public bool WasPayed { get; set; }

        public CommitionBonus(int commitionPrecent, string description, int dealProfit)
        {
            CommitionPrecent = commitionPrecent;
            AmountToPay = dealProfit * (0.01 * commitionPrecent);
            Description = description;
            DealProfit = dealProfit;
            WasPayed = false;
        }



    }
}
