using System;
using System.Collections.Generic;
using System.Text;

namespace Heroi
{
    public class Monstro
    {


        public string NomeMonstro { get; set; }
        public int PontosDeVida { get; set; }
        public int PontosDeAtaque { get; set; }
        public int RecompensaXP { get; set; }
        public bool EstaVivo => true;

        public object Nome { get; }
        public object PontosDeVida1 { get; }
        public object PontosDeAtaque1 { get; }
        public object RecompensaXP1 { get; }



    }
    
}
