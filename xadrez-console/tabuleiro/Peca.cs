namespace tabuleiro
{
    class Peca
    {
        public Cor Cor { get; protected set; }
        public Posicao Posicao { get; set; }
        public int  QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Cor = cor;
            Posicao = null;
            Tab = tab;
            QteMovimentos = 0;
        }
    }
}
