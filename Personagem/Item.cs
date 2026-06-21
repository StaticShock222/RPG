using System;
using System.Collections.Generic;
using System.Text;

namespace Personagem
{
    public class Item
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Raridade { get; set; }
        public int BonusAtaque { get; set; }
        public int BonusDefesa { get; set; }
        public double Preco { get; set; }
    }
}
