using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    abstract class Animal
    {
        public string Nome { get; set; }
        private int idade;

        public int Idade
        {
            get { return idade; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Idade não pode ser negativa");
                idade = value;
            }
        }

        public abstract void EmitirSom();

        public virtual void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }

    class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Au Au");
        }
    }

    class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Miau");
        }
    }

    class Passaro : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Piu Piu");
        }

        public void Voar()
        {
            Console.WriteLine($"{Nome} está voando!");
        }
    }

    class Zoo
    {
        private List<Animal> animais = new List<Animal>();

        public List<Animal> Animais => animais;

        public void AdicionarAnimal(Animal animal)
        {
            animais.Add(animal);
        }

        public void MostrarAnimais()
        {
            foreach (var animal in animais)
            {
                animal.Apresentar();
                animal.EmitirSom();
            }
        }
    }

    class Veterinario
    {
        public void Examinar(Animal animal)
        {
            animal.EmitirSom();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            Veterinario vet = new Veterinario();
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Adicionar Cachorro");
                Console.WriteLine("2. Adicionar Gato");
                Console.WriteLine("3. Adicionar Pássaro");
                Console.WriteLine("4. Mostrar Animais");
                Console.WriteLine("5. Examinar Animal");
                Console.WriteLine("6. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                Animal animal = null;
                switch (opcao)
                {
                    case 1:
                        animal = new Cachorro();
                        break;
                    case 2:
                        animal = new Gato();
                        break;
                    case 3:
                        animal = new Passaro();
                        break;
                    case 4:
                        zoo.MostrarAnimais();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        continue;
                    case 5:
                        Console.Write("Digite o nome do animal a ser examinado: ");
                        string nome = Console.ReadLine();
                        animal = zoo.Animais.Find(a => a.Nome == nome);
                        if (animal != null)
                        {
                            vet.Examinar(animal);
                        }
                        else
                        {
                            Console.WriteLine("Animal não encontrado.");
                        }
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        continue;
                }

                if (animal != null)
                {
                    Console.Write("Digite o nome do animal: ");
                    animal.Nome = Console.ReadLine();
                    Console.Write("Digite a idade do animal: ");
                    animal.Idade = int.Parse(Console.ReadLine());
                    zoo.AdicionarAnimal(animal);
                }

            } while (opcao != 6);
        }
    }
}
