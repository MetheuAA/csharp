using System;

public class Personagem
{
    public string Nome { get; set; }
    public int HP { get; set; }
    public int Ataque { get; set; }

    public Personagem(string nome, int hp, int ataque)
    {
        Nome = nome;
        HP = hp;
        Ataque = ataque;
    }

    public void Atacar(Personagem alvo)
    {
        alvo.HP -= Ataque;
        Console.WriteLine($"{Nome} atacou {alvo.Nome} causando {Ataque} de dano.");
        Console.WriteLine($"{alvo.Nome} tem {Math.Max(0, alvo.HP)} HP restante.");
    }

    public void ExibirStatus()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"HP: {HP}");
    }
}