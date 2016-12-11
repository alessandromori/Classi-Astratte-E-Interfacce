using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_astratte
{
    abstract class Pesce : Animale_Acquatico
    {
        public Pesce(string nome, string habitat) : base(nome, habitat)
        { }
        public override string StampaMovimento()
        {
            return "nuota";
        }
    }
}
