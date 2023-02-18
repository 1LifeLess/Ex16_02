namespace Exercise16_2.Ex1
{
    public class GlobalEmployeeWithCommition : GlobalEmployee
    {

        public void AddExtraPayment(CommitionBonus extraPayment)
        {
            ExtraPayments.Add(extraPayment);
        }

        public override double AmountLeftToPay()
        {
            double sum = 0;
            foreach (CommitionBonus extraPayment in ExtraPayments)
            {
                if (!extraPayment.WasPayed)
                    sum += extraPayment.AmountToPay;
            }
            return sum;
        }
        public override void Pay()
        {
            foreach (CommitionBonus extraPayment in ExtraPayments)
            {
                extraPayment.WasPayed = true;
            }
        }
    }
}
