using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAnimais.Classes
{
    public class Ornitorrinco : Mamifero, IOviparo, IAquatico
    {
        public Ornitorrinco(string nome, DateTime dataNascimento, char sexo, bool viveEmTerra = true, bool mergulho = true, bool aguaDoce = true, bool carnivoro = true, bool peconhento = true, int qtdeMamas = 0, bool pelos = true, string corPelo = "Marrom") : base(nome, dataNascimento, sexo, carnivoro, peconhento, qtdeMamas, pelos, corPelo)
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
            Console.WriteLine("Eu posso botar de 2 a 3 ovos.");
        }

        public void Chocar()
        {
            Console.WriteLine("Eu choco meus ovos por entre 10 e 14 dias.");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Eu me comunico por sons subaquáticos e através do contato do meu bico.");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Eu ando e nado.");
        }

        public override void Amamentar()
        {
            Console.WriteLine("Eu amamento meus filhotes de uma maneira diferente, pois não possuo mamas. Meu leite escorre de minha pele!");
        }
    }
}