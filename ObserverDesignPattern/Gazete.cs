using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    class Gazete : IObserver
    {
        public void Update(float faizOrani)
        {
            Console.WriteLine("Yeni Faiz oranları açıklandı: " + faizOrani);
        }
    }
}
