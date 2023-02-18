namespace Exercise16_2.Ex1
{
    public abstract class GlobalEmployee : Employee
    {
        protected List<ExtraPayment> ExtraPayments;
        protected int BaseSalary { get; set; }
        public GlobalEmployee()
        {
            ExtraPayments = new List<ExtraPayment>();
        }



    }
}
