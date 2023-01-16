using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAnimais.Classes
{
    public class Lontra : Mamifero, IAquatico
    {
        public Lontra(string nome, DateTime dataNascimento, char sexo, bool viveEmTerra = false, bool mergulho = true, bool aguaDoce = true, bool carnivoro = true, bool peconhento = false, int qtdeMamas = 6, bool pelos = true, string corPelo = "Chumbo") : base(nome, dataNascimento, sexo, carnivoro, peconhento, qtdeMamas, pelos, corPelo)
        {
            ViveEmTerra = viveEmTerra;
            Mergulho = mergulho;
            AguaDoce = aguaDoce;
        }

        public bool ViveEmTerra { get; init; }
        public bool Mergulho { get; init; }
        public bool AguaDoce { get; init; }

        public override void Comunicar()
        {
            Console.WriteLine("Eu sou um animal muito vocal e me comunico com diversos sons. Também uso olfato e comunicação corporal.");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Eu sou uma nadadora veloz, mas também posso andar.");
        }
    }
}