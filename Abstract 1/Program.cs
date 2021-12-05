using System;

namespace Abstract_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fir fir = new Fir();

            fir.Age = 33;
            fir.Type = "Candles";
            fir.Trunk = "Thick";

            Console.WriteLine("Küknarın yaşı:"+fir.Age);
            Console.WriteLine("Küknarın növü:"+fir.Type);
            Console.WriteLine("Kwknarın gövdesi:"+fir.Trunk);
            fir.Breathe();
            
        }
    }
}
