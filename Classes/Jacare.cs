using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAnimais.Classes
{
    public class Jacare : Reptil, IOviparo, IAquatico
    {
        public Jacare(string nome, DateTime dataNascimento, char sexo, bool viveEmTerra = true, bool mergulho = true, bool aguaDoce = true, bool carnivoro = true, bool peconhento = false, bool temEscamas = true, bool temCasco = false) : base(nome, dataNascimento, sexo, carnivoro, peconhento, temEscamas, temCasco)
        {
            ViveEmTerra = viveEmTerra;
            Mergulho = mergulho;
            AguaDoce = aguaDoce;
        }

        public bool ViveEmTerra { get; init; }
        public bool Mergulho { get; init; }
        public bool AguaDoce { get; init; }

        public void Botar()
        {
            Console.WriteLine("Eu posso botar por volta de 40 ovos.");
        }

        public void Chocar()
        {
            Console.WriteLine("Eu não choco ovos. Eles eclodem em cerca de 80 dias.");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Eu me comunico com outros de minha espécie movimentos corporais e vibrações debaixo d'água.");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Eu ando e nado.");
        }
    }
}