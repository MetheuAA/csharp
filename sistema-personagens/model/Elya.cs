using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_personagens.model
{
    public class Elya: Personagens
    {
        private string feitiço;
        private bool temSegredo;

        public Elya(string nome, string classe, int nivel, string genero, string feitiço, bool temSegredo) : base(nome, classe, nivel, genero)
        {
            this.feitiço = feitiço;
            this.temSegredo = temSegredo;
        }

        public string GetFeitiço()
        {
            return feitiço;
        }

        public void SetFeitiço(string feitiço)
        {
            this.feitiço = feitiço;
        }

        public bool GetTemSegredo()
        {
            return temSegredo;
        }

        public void SetTemSegredo(bool temSegredo)
        {
            this.temSegredo = temSegredo;
        }

        public override void Atacar(string incremento)
        {
            feitiço += incremento;
            Console.WriteLine($"Elya lança seu feitiço de {feitiço} contra o inimigo!");
        }

        public void DescobrirSegredo()
        {
            Console.WriteLine("Elya revela um segredo misterioso!");
        }

        public override void ObterDadosDoPersonagem()
        {
            Console.WriteLine($"\nDados do personagem:\n");
            Console.WriteLine($"Nome: {GetNome()}");
            Console.WriteLine($"Classe: {GetClasse()}");
            Console.WriteLine($"Nivel: {GetNivel()}");
            Console.WriteLine($"Feitiço: {GetFeitiço()}");
            Console.WriteLine($"Tem Segredo?: {(GetTemSegredo() ? "Sim" : "Não")}");
        }
    }
}
