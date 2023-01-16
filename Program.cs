using System;
using System.Collections.Generic;
using ExercicioAnimais.Classes;

namespace ExercicioAnimais
{
    class Program
    {
        public static void Main(string[] args)
        {
            var arara = new Arara("Arara macho", new DateTime(2021, 04, 25), 'm', 1);
            var chacal = new Chacal("Chacal fêmea", new DateTime(2021, 12, 01), 'f');
            var cisne = new Cisne("Cisne fêmea", new DateTime(2022, 01, 05), 'f');
            var coruja = new Coruja("Coruja macho", new DateTime(2019, 05, 03), 'm');
            var dragaoDeKomodo = new DragaoDeKomodo("Dragão de Komodo fêmea", new DateTime(2019, 01, 12), 'f');
            var elefante = new Elefante("Elefante macho", new DateTime(2020, 12, 01), 'm');
            var jacare = new Jacare("Jacaré macho", new DateTime(2019, 01, 20), 'm');
            var leao = new Leao("Leoa", new DateTime(2016, 10, 01), 'f');
            var lontra = new Lontra("Lontra fêmea", new DateTime(2016, 05, 11), 'f');
            var morcego = new Morcego("Morcego macho", new DateTime(2023, 01, 02), 'm', false, false);
            var ornitorrinco = new Ornitorrinco("Orni fêmea", new DateTime(2021, 07, 28), 'f');
            var pinguim = new Pinguim("Pingu macho", new DateTime(2017, 09, 27), 'm');

            List<Animal> animais = new List<Animal>();

            animais.Add(arara);
            animais.Add(chacal);
            animais.Add(cisne);
            animais.Add(coruja);
            animais.Add(dragaoDeKomodo);
            animais.Add(elefante);
            animais.Add(jacare);
            animais.Add(leao);
            animais.Add(lontra);
            animais.Add(morcego);
            animais.Add(ornitorrinco);
            animais.Add(pinguim);

            foreach (var animal in animais)
            {
                Console.WriteLine(animal.Nome);
                Console.WriteLine($"Idade: {animal.Idade}");
                animal.Movimentar();
                animal.Comunicar();
                animal.Alimentar();

                if (animal is Mamifero)
                {
                    var mamifero = (Mamifero)animal;
                    mamifero.Amamentar();
                }

                if (animal is Ave)
                {
                    var ave = (Ave)animal;
                    ave.Ciscar();
                }

                if (animal is Reptil)
                {
                    var reptil = (Reptil)animal;
                    Console.WriteLine($"Tem escamas? {reptil.TemEscamas}");
                }

                if (animal is IOviparo)
                {
                    var oviparo = (IOviparo)animal;
                    oviparo.Botar();
                    oviparo.Chocar();
                }

                if (animal is IVoar)
                {
                    var voador = (IVoar)animal;
                    voador.Voar();
                }

                Console.WriteLine("_________________________");
            }
        }
    }
}

