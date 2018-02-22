using System;

namespace cilindro
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string alt;
            string rai;
            double altc;
            double raic;
            double Volume;
            double Superficie;


            Console.WriteLine("Insira a altura do cilindro");
            alt = Console.ReadLine();
            altc = Convert.ToDouble(alt);
            Console.WriteLine("Insira o raio do cilindro");
            rai = Console.ReadLine();
            raic = Convert.ToDouble(rai);

            Volume = Math.PI * raic * raic * altc;
            Console.WriteLine(Volume);

            Superficie = 2 * Math.PI * raic * (raic + altc);
            Console.WriteLine(Superficie);
        }
    }
}
