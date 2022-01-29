using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4.Classes
{
    class Animal
    {
        public string Especie { get; set; }
        public string Cor { get; set; }
        public double Comprimento { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public int Olhos { get; set; }
        public string CorOlhos { get; set; }
        public string Habitat { get; set; }

        public void Comer(string alimento)
        {
            Console.WriteLine($"O animal { Especie } esta comendo { alimento }");
        }

        public void Locomover(string destino)
        {
            Console.WriteLine($"O animal { Especie } esta se locomovendo para { destino }");
        }

        public void Comunicar(Animal animal)
        {
            Console.WriteLine($"O animal { Especie } esta se comunicando com { animal.Especie }");
        }

    }
}
