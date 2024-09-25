using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UF1844Csharp
{
    internal private class ReproductorBasico:Reproductor,IPausa
    {
        public void reproducir();
        public void pausar();

        public void reanudar();
    }
}
