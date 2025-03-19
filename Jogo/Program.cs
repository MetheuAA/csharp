using System;

public class Jogo
{
    public static void Main(string[] args)
    {
        Personagem jogador1 = new Personagem("Jogador 1", 100, 20);
        Personagem jogador2 = new Personagem("Jogador 2", 100, 25);

        Personagem jogadorAtual = jogador1;

        while (jogador1.HP > 0 && jogador2.HP > 0)
        {
            jogadorAtual.Atacar(jogadorAtual == jogador1 ? jogador2 : jogador1);

            if (jogadorAtual.HP <= 0)
            {
                break;
            }

            jogadorAtual = jogadorAtual == jogador1 ? jogador2 : jogador1;
        }

        if (jogador1.HP <= 0)
        {
            Console.WriteLine($"{jogador2.Nome} venceu!");
        }
        else
        {
            Console.WriteLine($"{jogador1.Nome} venceu!");
        }
    }
}