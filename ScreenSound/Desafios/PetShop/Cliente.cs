using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Desafios.PetShop
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        private List<Pet> Pets { get; set; }

        public Cliente(string nome, int idade, string email)
        {
            Nome = nome;
            Idade = idade;
            Email = email;
            Pets = new List<Pet>(); // Estado inicial
        }

        public void AdicionarPet(Pet pet)
        {
            if (this.Idade < 18)
            {
                Console.WriteLine("Você é menor de idade, peça a um responsável");
            }
            else
            {
                Pets.Add(pet);
            }
        }

        public void ListarPets()
        {
            if (Pets.Count > 0)
            {
                Console.WriteLine($"O {this.Nome} é dono do(s) Pet(s): \n");
                foreach (var pet in Pets)
                {
                    Console.WriteLine(pet.Nome);
                }

            }
            else
            {
                Console.WriteLine($"O {this.Nome} não tem pet");
            }
        }
    }
}
