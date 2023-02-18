namespace Exercise16_2.Ex4
{
    public class ImObserver : IObservr
    {
        public ImObserver()
        {

        }

        public void Subscribe(DataStore observable)
        {
            observable.Subscribe(this);
        }

        public void NotifyOnChange(int x)
        {
            Console.WriteLine($"onChange event activated, new X value is: {x}");
        }

        public void Unsubscribe(DataStore observable)
        {
            observable.Unsubscribe(this);
            Console.WriteLine("usubscribed");
        }

    }
}
