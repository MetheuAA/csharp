
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.model
{
    public class Moto: Veiculo
    {
        private bool partidaEletrica{get; set;}
        private bool protetorDeCarenagem{get; set;}

        public Moto(string marca, string modelo, int ano, double velocidadeAtual, bool partidaEletrica, bool protetorDeCarenagem) : base(marca, modelo, ano, velocidadeAtual)
        {
            this.partidaEletrica = partidaEletrica;
            this.protetorDeCarenagem = protetorDeCarenagem;
        }
        public bool GetPartidaEletrica()
        {
            return partidaEletrica;
        }
         public void SetPartidaEletrica(bool partidaEletrica)
        {
            this.partidaEletrica=partidaEletrica;
        }

        public bool GetProtetorDeCarenagem()
        {
            return protetorDeCarenagem;
        }
        public void SetProtetorDeCarenagem(bool protetorDeCarenagem)
        {
            this.protetorDeCarenagem=protetorDeCarenagem;
        }

        public override void Acelerar(double incremento)
        {
            velocidadeAtual += incremento;
            Console.WriteLine($"A moto acelerou e atingiu a velocidade de {velocidadeAtual} km/h.");
        }

        public void Empinar()
        {
            Console.WriteLine("Empinando a moto!");
        }
    }
}
