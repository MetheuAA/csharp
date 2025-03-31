class Program {
    static void Main(string[] args) {

        IAtaque guerreiro = new Guerreiro();
        IAtaque mago = new Mago();
        IAtaque arqueiro = new Arqueiro();

        guerreiro.Atacar();
        mago.Atacar();
        arqueiro.Atacar();
    }
}