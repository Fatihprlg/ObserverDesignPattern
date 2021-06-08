using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    class Internet : IObserver
    {
        public void Update(float faizOrani)
        {
            Console.WriteLine("Faiz oranları internete sızdı: " + faizOrani);
        }
    }
}
