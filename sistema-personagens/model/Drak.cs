using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_personagens.model
{
    public class Drak : Personagens
    {
        private string totem;
        private bool emRaiva;

        public Drak(string nome, string classe, int nivel, string genero, string totem, bool emRaiva) 
            : base(nome, classe, nivel, genero)
        {
            this.totem = totem;
            this.emRaiva = emRaiva;
        }

        public string GetTotem()
        {
            return totem;
        }

        public void SetTotem(string totem)
        {
            this.totem = totem;
        }

        public bool GetEmRaiva()
        {
            return emRaiva;
        }

        public void SetEmRaiva(bool emRaiva)
        {
            this.emRaiva = emRaiva;
        }

        public override void Atacar(string incremento)
        {
            totem += incremento;
            Console.WriteLine($"Drak usa seu {totem} em um ataque feroz!");
        }

        public void Destruir()
        {
            Console.WriteLine("Drak em raiva destrói tudo ao seu redor!");
        }

        public override void ObterDadosDoPersonagem()
        {
            Console.WriteLine($"\nDados do personagem:\n");
            Console.WriteLine($"Nome: {GetNome()}");
            Console.WriteLine($"Classe: {GetClasse()}");
            Console.WriteLine($"Nivel: {GetNivel()}");
            Console.WriteLine($"Totem: {GetTotem()}");
            Console.WriteLine($"Em Raiva?: {(GetEmRaiva() ? "Sim" : "Não")}");
        }


         public override void RealizarAcaoEspecial()
    {
        if (emRaiva)
        {
            Console.WriteLine($"{GetNome()} usa seu totem {totem} para desferir um ataque furioso!");
        }
        else
        {
            Console.WriteLine($"{GetNome()} usa seu totem {totem} em um ataque básico.");
        }
    }
}
}