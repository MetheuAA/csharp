public class Program
{
    public static void Main()
    {
        Heroi guerreiro = new Guerreiro("Thor");
        Heroi mago = new Mago("Merlin");
        Heroi arqueiro = new Arqueiro("Legolas");
        
        guerreiro.Atacar();
        guerreiro.Especial();
        
        mago.Atacar();
        mago.Especial();
        
        arqueiro.Atacar();
        arqueiro.Especial();
    }
}
