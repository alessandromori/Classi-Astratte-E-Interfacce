using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_astratte
{
    abstract class Animale
    {
        protected string nomeAnimale;
        protected string tipoAnimale;
        protected string habitat;
        protected int numeroZampe;

        public Animale(string nome, string tipo, string abitat, int zampe )
        {
            nomeAnimale = nome;
            tipoAnimale = tipo;
            habitat = abitat;
            numeroZampe = zampe;
        }
        public abstract string StampaMovimento();
        
        public void Riepilogo()
        {
            Console.WriteLine("nome : " +nomeAnimale);
            Console.WriteLine("tipo : " +tipoAnimale);
            Console.WriteLine("habitat : " + habitat);
            Console.WriteLine("Numero zampe : "+numeroZampe);
            Console.WriteLine("Movimento : " + StampaMovimento());
        }
    }
}
