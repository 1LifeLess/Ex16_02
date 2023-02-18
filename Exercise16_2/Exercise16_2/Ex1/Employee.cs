namespace Exercise16_2.Ex1
{
    public abstract class Employee
    {
        string JobTitle { get; set; }

        public abstract double AmountLeftToPay();
        public abstract void Pay();
    }
}
