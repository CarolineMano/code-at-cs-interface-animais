using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAnimais
{
    public abstract class Mamifero : Animal
    {
        public Mamifero(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconhento, int qtdeMamas, bool pelos, string corPelo) : base(nome, dataNascimento, sexo, carnivoro, peconhento)
        {
            QtdeMamas = qtdeMamas;
            Pelos = pelos;
            CorPelo = pelos ? corPelo : "N/A";
        }

        public int QtdeMamas { get; init; }
        public bool Pelos { get; init; }
        public string CorPelo { get; init; }

        public virtual void Amamentar()
        {
            if (Sexo == 'f')
                Console.WriteLine($"Posso amamentar meu filhote, pois possuo {QtdeMamas} mamas!");

            else    
                Console.WriteLine("Eu não posso amamentar. Só a fêmea faz isso!");
        }
    }
}