using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interface.Model.Interface;
namespace Interface.Model
{
    class Cachorro : IAnimal {
        public void EmitirSom() {
            Console.WriteLine("Latindo...");
        }

        public void Mover() {
            Console.WriteLine("Caminhando...");
        }
    }
}