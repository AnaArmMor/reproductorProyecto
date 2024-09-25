using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UF1844Csharp
{
    internal private class ReproductorPremium:Reproductor,ICambioVelocidad
    {
        public void reproducir();
        public void pausar();
        public void reanudar();
        public void reproducirLento();
        public void reproducirRapido();

    }
}
