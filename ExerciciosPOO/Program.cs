using System;

namespace ExerciciosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animais = new Animal[3];
            animais[0] = new Gato();
            animais[1] = new Pato();
            animais[2] = new Cachorro();

            for (int i = 0; i < animais.Length; i++)
            {
                animais[i].EmitirSom();
            }
        }
    }
}
