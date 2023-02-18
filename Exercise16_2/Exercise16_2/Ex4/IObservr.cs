namespace Exercise16_2.Ex4
{
    public interface IObservr
    {

        public void Subscribe(DataStore observable);

        public void NotifyOnChange(int x);

        public void Unsubscribe(DataStore observable);
    }
}
