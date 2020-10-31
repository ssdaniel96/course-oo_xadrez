namespace tabuleiro
{
    class Peca
    {
        public Cor Cor { get; set; }
        public Posicao Posicao { get; protected set; }
        public int  QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Posicao posicao, Tabuleiro tab)
        {
            Cor = cor;
            Posicao = posicao;
            Tab = tab;
            QteMovimentos = 0;
        }
    }
}
