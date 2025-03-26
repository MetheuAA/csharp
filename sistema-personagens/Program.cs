using sistema_personagens.model;

class Program
{
    static void Main()
    {
        // Criação das instâncias e exibição dos dados
        Tasha tasha = new Tasha("Tasha", "Maga", 33, "Mulher", "Fogo", true);
        tasha.ObterDadosDoPersonagem();
        tasha.RealizarAcaoEspecial();
        tasha.Defender();  // Demonstra o uso do método Defender

        Jarcem jarcem = new Jarcem("Jarcem", "Guerreiro", 25, "Homem", "Espada Longa", true);
        jarcem.ObterDadosDoPersonagem();
        jarcem.RealizarAcaoEspecial();
        jarcem.Defender();  // Demonstra o uso do método Defender

        Elya elya = new Elya("Elya", "Maga", 40, "Mulher", "Feitiço de Gelo", true);
        elya.ObterDadosDoPersonagem();
        elya.RealizarAcaoEspecial();
        elya.Defender();  // Demonstra o uso do método Defender

        Drak drak = new Drak("Drak", "Guerreiro Bárbaro", 45, "Homem", "Totem do Lobo", true);
        drak.ObterDadosDoPersonagem();
        drak.RealizarAcaoEspecial();
        drak.Defender();  // Demonstra o uso do método Defender
    }
}
