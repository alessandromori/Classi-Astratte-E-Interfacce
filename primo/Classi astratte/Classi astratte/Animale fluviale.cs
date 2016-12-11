using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_astratte
{
    abstract class Animale_fluviale : Pesce
    {
        public Animale_fluviale(string nome) : base(nome, "Fiume") 
        { }
    }
}
