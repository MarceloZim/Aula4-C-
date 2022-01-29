using System;
using Aula4.Classes;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem");

            Console.WriteLine();

            Animal leao = new Animal();
            leao.Especie = "Leão";
            leao.Cor = "Azul";
            leao.Comprimento = 2;
            leao.Altura = 1;
            leao.Peso = 50;
            leao.Olhos = 3;
            leao.CorOlhos = "Castanho";
            leao.Habitat = "Savana";

            Animal baleia = new Animal();
            baleia.Especie = "Baleia";
            baleia.Cor = "Rosa";
            baleia.Comprimento = 200;
            baleia.Altura = 40;
            baleia.Peso = 2000;
            baleia.Olhos = 5;
            baleia.CorOlhos = "Vermelho";
            baleia.Habitat = "Ceu";

            baleia.Comer("Passarinhos");
            leao.Comer("Pessoas");

            baleia.Locomover("Angeloni");
            leao.Locomover("Angeloni");

            baleia.Comunicar(leao);
        }
    }
}
