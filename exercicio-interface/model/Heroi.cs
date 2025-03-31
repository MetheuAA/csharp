public abstract class Heroi : IAtacante
{
    public string Nome { get; set; }
    
    public Heroi(string nome)
    {
        Nome = nome;
    }
    
    public abstract void Especial();
    public abstract void Atacar();
}