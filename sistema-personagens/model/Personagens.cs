using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_personagens.model
{
    public abstract class Personagens
    {
        private string nome;
        private string classe;
        private int nivel;
        protected string genero;

        public Personagens(string nome, string classe, int nivel, string genero)
        {
            this.nome = nome;
            this.classe = classe;
            this.nivel = nivel;
            this.genero = genero;
        }

        ////////////////////////////////////////////////////////////////
        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        ////////////////////////////////////////////////////////////////
        public string GetClasse()
        {
            return classe;
        }

        public void SetClasse(string classe)
        {
            this.classe = classe;
        }

        ////////////////////////////////////////////////////////////////
        public int GetNivel()
        {
            return nivel;
        }

        public void SetNivel(int nivel)
        {
            this.nivel = nivel;
        }

        ////////////////////////////////////////////////////////////////
        public string GetGenero()
        {
            return genero;
        }

        public void SetGenero(string genero)
        {
            this.genero = genero;
        }

        ////////////////////////////////////////////////////////////////
        public virtual void Atacar(string incremento)
        {
            nome += incremento;
            Console.WriteLine($"{nome} realiza um ataque.");
        }

        public void Receba(string incremento)
        {
            nome = incremento;
            Console.WriteLine($"{nome} recebeu um ataque");
        }

        ////////////////////////////////////////////////////////////////
        // Método abstrato que deve ser implementado pelas classes derivadas
        public abstract void ObterDadosDoPersonagem();

        // Método abstrato que deve ser implementado pelas classes derivadas
        public abstract void RealizarAcaoEspecial();  // Método abstrato

        // Método concreto que pode ser utilizado diretamente ou sobrecarregado nas classes derivadas
        public void Defender()
        {
            Console.WriteLine($"{nome} se prepara para se defender.");
        }
    }
}
