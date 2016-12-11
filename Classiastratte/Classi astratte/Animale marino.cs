using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_astratte
{
    abstract class Animale_marino : Pesce
    {
        public Animale_marino(string nome) : base(nome, "mare")
        { }
    }
}
