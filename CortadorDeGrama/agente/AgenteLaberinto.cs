using CortadorDeGrama.ambiente;
using System;
using System.Collections.Generic;
using System.Text;

namespace CortadorDeGrama.agente
{

    public class AgenteLaberinto
    {
        public Labirinto laberinto  { get; set; }

        private MovimentoAgenteLaberinto movimento;

        public AgenteLaberinto(Labirinto laberinto)
        {
            this.laberinto = laberinto;

            this.movimento = MovimentoAgenteLaberinto.CIMA;
        }
    }
}
 