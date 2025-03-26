using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_personagens.model
{
    public class Tasha : Personagens
    {
        private string magia;
        private bool existe;

        public Tasha(string nome, string classe, int nivel, string genero, string magia, bool existe) 
            : base(nome, classe, nivel, genero)
        {
            this.magia = magia;
            this.existe = existe;
        }

        public string GetMagia()
        {
            return magia;
        }

        public void SetMagia(string magia)
        {
            this.magia = magia;
        }

        public bool GetExiste()
        {
            return existe;
        }

        public void SetExiste(bool existe)
        {
            this.existe = existe;
        }

        public override void Atacar(string incremento)
        {
            magia += incremento;
            Console.WriteLine($"Tasha utiliza seu {magia} para atacar seu inimigo");
        }

        public void Parar()
        {
            Console.WriteLine("Ficou com dó e parou de atacar");
        }

        public override void ObterDadosDoPersonagem()
        {
            Console.WriteLine($"\nDados do personagem:\n");
            Console.WriteLine($"Nome: {GetNome()}");
            Console.WriteLine($"Classe: {GetClasse()}");
            Console.WriteLine($"Nivel: {GetNivel()}");
            Console.WriteLine($"Magia: {GetMagia()}");
            Console.WriteLine($"Existe?: {(GetExiste() ? "Sim" : "Não")}");
        }

         public override void RealizarAcaoEspecial()
    {
        if (existe)
        {
            Console.WriteLine($"{GetNome()} conjura uma poderosa magia: {magia}!");
        }
        else
        {
            Console.WriteLine($"{GetNome()} não consegue realizar nenhuma ação especial, pois não existe no momento.");
        }
    }
}
}
