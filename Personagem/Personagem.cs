using System;
using System.Collections.Generic;
using System.Text;

namespace Personagem
{
    public class Personagem
    {
        public int PontosDeMana;
        private int _nivel;
        public int PontosDeAtaque { get; set; }
        public int PontosDeVida { get; set; }
        public int Nivel
        {
            get => _nivel;
            set
            {
                _nivel = value;
                PontosDeVida = _nivel * 5;
                PontosDeMana = _nivel * 10;
            }
        }
        public bool EstaVivo { get; set; } = true;
        public int Ataque(int PontosDeAtaque)
        {
            PontosDeVida -= PontosDeAtaque;
            EstaVivo = PontosDeVida > 0;
            return PontosDeVida;
        }

    }
}
