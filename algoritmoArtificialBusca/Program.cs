using algoritmoArtificialBusca.nos;
using System;

namespace algoritmoArtificialBusca
{
    class Program
    {
        static void Main(string[] args)
        {
            NO no0 = new NO(0);
            NO no1 = new NO(1);
            NO no2 = new NO(2);
            NO no3 = new NO(3);
            NO no4 = new NO(4);
            NO no5 = new NO(5);
            NO no6 = new NO(6);
            NO no7 = new NO(7);
            NO no8 = new NO(8);

            //no.noEsquerda = no;
            //no.noDireita = no;

            no0.noEsquerda = no1;
            no0.noDireita = no2;

            no1.noEsquerda = no3;
            no1.noDireita = no4;

            no2.noEsquerda = no5;
            no2.noDireita = no6;


        }
    }
}
