public class Guerreiro : Heroi
{
    public Guerreiro(string nome) : base(nome) { }
    
    public override void Atacar()
    {
        Console.WriteLine($"{Nome} golpeia com sua espada!");
    }
    
    public override void Especial()
    {
        Console.WriteLine($"{Nome} usa o Golpe Devastador!");
    }
}