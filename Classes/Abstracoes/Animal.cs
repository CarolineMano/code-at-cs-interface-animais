using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAnimais
{
    public abstract class Animal
    {
        protected Animal(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconhento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            Carnivoro = carnivoro;
            Peconhento = peconhento;
        }

        public string Nome { get; init; }
        public DateTime DataNascimento { get; init; }
        public char Sexo { get; init; }
        public int Idade
        {
            get { return DataNascimento.Month > DateTime.Now.Month && DataNascimento.Day > DateTime.Now.Day ? 
                    (DateTime.Now.Year - DataNascimento.Year) - 1 : (DateTime.Now.Year - DataNascimento.Year); }
        }
        
        public bool Carnivoro { get; init; }
        public bool Peconhento { get; init; }

        public abstract void Movimentar();
        public abstract void Comunicar();
        public void Alimentar()
        {
            if (Carnivoro)
                Console.WriteLine("Eu como carne.");

            else
                Console.WriteLine("Eu como plantas.");
        }
    }
}