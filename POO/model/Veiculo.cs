using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.model
{
    public class Veiculo
    {
        // Atributos
        private string marca;
        private string modelo;
        private int ano;
        protected double velocidadeAtual;

        // Construtor
        public Veiculo(string marca, string modelo, int ano, double velocidadeAtual)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this.velocidadeAtual = velocidadeAtual;
        }
        public string GetMarca()
        {
            return marca;
        }
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
        // Métodos Andar e Falar
        public void Acelerar(double incremento)
        {
            velocidadeAtual += incremento;
            Console.WriteLine($"Acelerando... Velocidade atual {velocidadeAtual} Km/h");
        }
        public void Frear(double decremento)
        {
            velocidadeAtual-= decremento;
            Console.WriteLine($"Freando... Velocidade atual {velocidadeAtual}Km/h");
        }
    }
}