using CortadorDeGrama.ambiente;
using CortadorDeGrama.geral;
using System;
using System.Collections.Generic;
using System.Text;

namespace CortadorDeGrama.agente
{

    public class AgenteLaberinto
    {
        public Labirinto laberinto  { get; set; }

        private MovimentoAgenteLaberinto movimento;
        private PosisaoXY posXY;

        public AgenteLaberinto(Labirinto laberinto)
        {
            this.laberinto = laberinto;
            this.posXY = new PosisaoXY();
            
            this.movimento = MovimentoAgenteLaberinto.CIMA;
        }

        public PosisaoXY retornarMovimento()
        {
            int retornaPosX = this.posXY.posX ;
            int retornaPosY = this.posXY.posY;

            switch (this.movimento )
            {
                case MovimentoAgenteLaberinto.CIMA: 
                    if(retornaPosX > 0){
                        retornaPosX -= 1;
                    }
                    break;
                case MovimentoAgenteLaberinto.BAIXO:
                    if(retornaPosX < this.laberinto.Tamanho - 1)
                    {
                        retornaPosX += 1;
                    }
                    break;
                case MovimentoAgenteLaberinto.ESQUERDA:
                    if(retornaPosY > 0)
                    {
                        retornaPosY -= 1;
                    }
                    break;
                case MovimentoAgenteLaberinto.DIEREITA:
                    if(retornaPosY < this.laberinto.Tamanho - 1)
                    {
                        retornaPosY -= 1;
                    }
                    break;
            }

            return new PosisaoXY(retornaPosX, retornaPosY);

        }
    }
}
 