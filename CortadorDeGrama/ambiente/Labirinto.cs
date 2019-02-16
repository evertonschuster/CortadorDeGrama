﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CortadorDeGrama.ambiente
{
    public class Labirinto
    {
        private int tamanho = 3;
        private String[][] labirinto = null;

        public Labirinto(int tamanho)
        {
            this.tamanho = tamanho;
            construirLabirinto();
        }

        private void construirLabirinto()
        {
            //Valores
            //--------------
            // S - Sujo
            // L - Limpo
            // A - Agente

            this.labirinto = new String[this.tamanho][];
            //Construtor do labirinto
            for (int j = 0; j < this.labirinto.Length; j++)
            {
                var item = this.labirinto[j] = new string[tamanho];
                for (int i = 0; i < item.Length; i++)
                {
                    item[i] = "S";
                }
            }

        }

        public void exibirLabirinto()
        {
            foreach (var item in this.labirinto)
            {
                foreach (var campo in item)
                {
                    Console.Write(campo + " ");
                }
                Console.Write("\n");
            }

        }
    }
}