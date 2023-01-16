using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAnimais.Classes
{
    public class Chacal : Mamifero
    {
        public Chacal(string nome, DateTime dataNascimento, char sexo, bool carnivoro = true, bool peconhento = false, int qtdeMamas = 8, bool pelos = true, string corPelo = "Amarelo ocre e preto") : base(nome, dataNascimento, sexo, carnivoro, peconhento, qtdeMamas, pelos, corPelo)
        {
        }

        public override void Comunicar()
        {
            Console.WriteLine("Eu me comunico através de uivos");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Eu me movimento sob as quatro patas");
        }
    }
}