using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_astratte
{
    abstract class Animale_Acquatico : Animale
    {
         public Animale_Acquatico(string nome, string habitat): base(nome, "acquatico", habitat, 0)
         { }
    }
}
