using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAnimais.Classes
{
    public class DragaoDeKomodo : Reptil, IOviparo
    {
        public DragaoDeKomodo(string nome, DateTime dataNascimento, char sexo, bool carnivoro = true, bool peconhento = true, bool temEscamas = true, bool temCasco = false) : base(nome, dataNascimento, sexo, carnivoro, peconhento, temEscamas, temCasco)
        {
        }

        public void Botar()
        {
            Console.WriteLine("Eu posso de 15 a 35 ovos.");
        }

        public void Chocar()
        {
            Console.WriteLine("Eu não choco ovos. Eles eclodem de 6 a 8 semanas.");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Eu me comunico com outros de minha espécie por contato visual e movimentos corporais.");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Eu ando sob as quatro patas.");
        }
    }
}