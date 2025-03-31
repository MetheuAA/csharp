public class Mago : Heroi
{
    public Mago(string nome) : base(nome) { }
    
    public override void Atacar()
    {
        Console.WriteLine($"{Nome} lança uma bola de fogo!");
    }
    
    public override void Especial()
    {
        Console.WriteLine($"{Nome} conjura uma tempestade arcana!");
    }
}