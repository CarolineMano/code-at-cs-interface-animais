using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAnimais.Classes
{
    public class Pinguim : Ave, IOviparo, IAquatico
    {
        public Pinguim(string nome, DateTime dataNascimento, char sexo, bool viveEmTerra = true, bool mergulho = true, bool aguaDoce = false, bool carnivoro = true, bool peconhento = false, bool rapina = false, string corPena = "Preta e branca") : base(nome, dataNascimento, sexo, carnivoro, peconhento, rapina, corPena)
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
            Console.WriteLine("Eu posso botar 1 ou 2 ovos.");
        }

        public void Chocar()
        {
            Console.WriteLine("Eu choco meus ovos por um tempo de 32 a 68 dias.");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Eu me comunico com sons e movimentos corporais.");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Eu ando e nado.");
        }
    }
}