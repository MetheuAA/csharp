using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_personagens.model
{
    public class Jarcem: Personagens
    {
        private string arma;
        private bool emBatalha;

        public Jarcem(string nome, string classe, int nivel, string genero, string arma, bool emBatalha) : base(nome, classe, nivel, genero)
        {
            this.arma = arma;
            this.emBatalha = emBatalha;
        }

        public string GetArma()
        {
            return arma;
        }

        public void SetArma(string arma)
        {
            this.arma = arma;
        }

        public bool GetEmBatalha()
        {
            return emBatalha;
        }

        public void SetEmBatalha(bool emBatalha)
        {
            this.emBatalha = emBatalha;
        }

        public override void Atacar(string incremento)
        {
            arma += incremento;
            Console.WriteLine($"Jarcem usa sua {arma} para atacar com força!");
        }

        public void Defendendo()
        {
            Console.WriteLine("Jarcem está se preparando para se defender!");
        }

        public override void ObterDadosDoPersonagem()
        {
            Console.WriteLine($"\nDados do personagem:\n");
            Console.WriteLine($"Nome: {GetNome()}");
            Console.WriteLine($"Classe: {GetClasse()}");
            Console.WriteLine($"Nivel: {GetNivel()}");
            Console.WriteLine($"Arma: {GetArma()}");
            Console.WriteLine($"Em Batalha?: {(GetEmBatalha() ? "Sim" : "Não")}");
        }
    }
}
