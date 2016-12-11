using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_astratte
{
    class Uomo : Bipede
    {
        public Uomo() : base("Uomo")
        { }
        public override string StampaMovimento()
        {
            return "cammina";
        }
    }
}
