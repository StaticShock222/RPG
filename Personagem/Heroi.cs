namespace Personagem
{
    public class Heroi : Personagem
    {
        public string Nome { get; set; }
        public string Classe { get; set; }
        public int PontosDeMana { get; set; }

        public bool TemArma { get; set; } = true;

        public int Ataque(int PontosDeAtaque)
        {
            if (TemArma == true)
            {
                PontosDeAtaque += 10;
                PontosDeVida -= PontosDeAtaque;
            }
            EstaVivo = PontosDeVida > 0;
            return PontosDeVida;
        }

    }
}
