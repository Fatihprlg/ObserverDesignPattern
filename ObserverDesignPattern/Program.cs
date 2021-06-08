using System;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Gazete gazete = new Gazete();
            Internet internet = new Internet();

            Kredi ihtiyacKredisi = new Kredi();
            ihtiyacKredisi.RegisterObserver(gazete);
            ihtiyacKredisi.RegisterObserver(internet);
            ihtiyacKredisi.setFaizOrani(1.15f); //gazete, internet

            ihtiyacKredisi.RemoveObserver(internet);
            ihtiyacKredisi.setFaizOrani(1.35f); //gazete

            ihtiyacKredisi.RemoveObserver(gazete);
            ihtiyacKredisi.setFaizOrani(1.0f); // --
        }
    }
}
