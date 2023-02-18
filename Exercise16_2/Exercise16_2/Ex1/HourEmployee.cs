namespace Exercise16_2.Ex1
{
    public abstract class HourEmployee : Employee
    {
        public int UnpaidWorkingHours { get; private set; }
        private double PaymentPerHour;

        public void AddWorkingHours(int workingHours)
        {
            UnpaidWorkingHours += workingHours;

        }
        public void UpdatePaymentPerHour(int newPayment)
        {
            PaymentPerHour = newPayment;
        }
        public override double AmountLeftToPay()
        {
            return UnpaidWorkingHours * PaymentPerHour;
        }
        public override void Pay()
        {
            UnpaidWorkingHours = 0;
        }
    }
}
