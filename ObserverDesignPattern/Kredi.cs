using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    public class Kredi : ISubject
    {
        private float faizOrani;
        private List<IObserver> observers;
        public Kredi()
        {
            observers = new List<IObserver>();
        }
        public void setFaizOrani(float faizOrani)
        {
            this.faizOrani = faizOrani;
            NotifyObservers();
        }
        public void NotifyObservers()
        {
            foreach(IObserver o in observers)
            {
                o.Update(faizOrani);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
    }
}
