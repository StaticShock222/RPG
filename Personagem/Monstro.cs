using System;
using System.Collections.Generic;
using System.Text;

namespace Personagem
{
    public class Monstro
    {
        public Monstro(string nomeMonstro, int pontosDeVida, int pontosDeAtaque, int recompensaXP, bool estaVivo)
        {
            NomeMonstro = nomeMonstro;
            PontosDeVida = pontosDeVida;
            PontosDeAtaque = pontosDeAtaque;
            RecompensaXP = recompensaXP;
            EstaVivo = estaVivo;
        }

        public Monstro(string nomeMonstro, int pontosDeVida, int pontosDeAtaque, int recompensaXP)
        {
            nomeMonstro = "Goblin";
            pontosDeAtaque = 10;
            pontosDeVida = 15;
            recompensaXP = 20;
        }

        public Monstro()
        {

        }

        public string NomeMonstro { get; set; }
        public int PontosDeVida { get; set; }
        public int PontosDeAtaque { get; set; }
        public int RecompensaXP { get; set; }
        public bool EstaVivo { get; set; } = true;



    }
    
}
