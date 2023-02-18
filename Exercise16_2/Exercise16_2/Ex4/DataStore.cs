using System;
using System.Collections.Generic;

namespace Exercise16_2.Ex4
{

    public class DataStore
    {
        private int x;
        private List<IObservr> observers;

        public DataStore(int x)
        {
            this.x = x;
            observers = new List<IObservr>();
        }

        public int X
        {
            get { return x; }
            set
            {
                x = value;
                NotifyObservers(value);
            }
        }

        public void Subscribe(IObservr observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }

        }

        private void NotifyObservers(int newX)
        {
            foreach (IObservr observer in observers)
            {
                observer.NotifyOnChange(newX);
            }
        }

        public void Unsubscribe(IObservr observer)
        {
            observers.Remove(observer);
        }
    }

}