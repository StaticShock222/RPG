using System;
using System.Collections.Generic;
using System.Text;

namespace Personagem
{
    public class Monstro:Personagem
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
        public int RecompensaXP { get; set; }
        public bool EstaVivo { get; set; } = true;

        public int Ataque(int PontosDeAtaque)
        {
            if (Nivel > 1)
            {
                PontosDeAtaque++;
            }
            PontosDeVida -= PontosDeAtaque;
            EstaVivo = PontosDeVida > 0;
            return PontosDeVida;
        }

        
    }
    
}
