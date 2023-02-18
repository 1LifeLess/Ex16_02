namespace Exercise16_2.Ex1
{
    public class GlobalEmployeeWithPerformance : GlobalEmployee
    {
        public GlobalEmployeeWithPerformance()
        {
        }

        public void AddExtraPayment(PerformanceBonus extraPayment)
        {
            ExtraPayments.Add(extraPayment);
        }

        public override double AmountLeftToPay()
        {
            double sum = 0;
            foreach (ExtraPayment extraPayment in ExtraPayments)
            {
                sum += extraPayment.AmountToPay;
            }
            return sum;
        }
        public override void Pay()
        {
            foreach (PerformanceBonus extraPayment in ExtraPayments)
            {
                extraPayment.WasPayed = true;
            }
        }
    }
}
