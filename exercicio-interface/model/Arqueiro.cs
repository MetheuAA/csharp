public class Arqueiro : Heroi
{
    public Arqueiro(string nome) : base(nome) { }
    
    public override void Atacar()
    {
        Console.WriteLine($"{Nome} dispara uma flecha precisa!");
    }
    
    public override void Especial()
    {
        Console.WriteLine($"{Nome} dispara uma chuva de flechas!");
    }
}