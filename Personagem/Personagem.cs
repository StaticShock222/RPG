namespace Heroi
{
    public class Personagem
    {
        private int _nivel;
        public string Nome { get; set; }
        public string Classe { get; set; }
        public int Nivel {
            get => _nivel;
            set
            {
                _nivel = value;
                PontosDeVida = _nivel * 5;
                PontosDeMana = _nivel * 10;
            }
        }
        public int PontosDeVida { get; set; }
        public int PontosDeMana { get; set; }

    }
}
