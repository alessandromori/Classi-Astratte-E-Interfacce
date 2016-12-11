using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_astratte
{
    abstract class Uccello : Bipede
    {
        public Uccello(string nome) : base(nome)
        { }
        public override string StampaMovimento()
        {
            return "vola";
        }
    }
}
