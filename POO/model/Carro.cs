using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.model
{
    public class Carro: Veiculo
    {
        public bool automatico;
        public int numeroDePortas;

        public Carro(string marca, string modelo, int ano, double velocidadeAtual, bool automatico, int numeroDePortas) : base(marca, modelo, ano, velocidadeAtual)
        {
            this.automatico = automatico;
            this.numeroDePortas = numeroDePortas;
        }
        public bool GetAutomatico()
        {
            return automatico;
        }
        public void SetAutomatico(bool automatico)
        {
            this.automatico=automatico;
        }
        public int GetNumeroDePortas()
        {
            return numeroDePortas;
        }
        public void SetNumeroDePortas(int numeroDePortas)
        {
            this.numeroDePortas=numeroDePortas;
        }
        public void AbrirPortas()
        {
            Console.WriteLine("As portas do carro estão abertas.");
        }
        public void Frear(double decremento, bool puxarFreioDeMao)
        {
            velocidadeAtual -= decremento;
            if(puxarFreioDeMao)
        {
            Console.WriteLine($"O carro freou até a velocidade de {velocidadeAtual} km/h para não bater");
        }
        else
        {
            Console.WriteLine($"O carro freou lentamente até {velocidadeAtual}km/h");
        }
        }

        public void Frear(double decremento, bool puxarFreioDeMao, bool virouVolante)
        {
            velocidadeAtual -= decremento;
            if(puxarFreioDeMao && virouVolante)
            {
                Console.WriteLine($"O carro está realizando um cavalinho de pau com intensidade de frenagem {velocidadeAtual}!");
            }
            else
            {
                Console.WriteLine($"O carro freou até {velocidadeAtual}km/h");
            }
        }
    }
}