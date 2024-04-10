namespace ScreenSound.Desafios.Automobilistica
{
    internal class Cliente(string nome, int idade, string contato)
    {
        public string Nome { get; } = nome;
        public int Idade { get; } = idade;
        public string Contato { get; } = contato;
        public string MaiorDeIdade => Idade > 18 ? "Maior de idade" : "Menor de idade";        


        public void InfoCliente()
        {
            Console.WriteLine("Informações do cliente:");
            Console.WriteLine($"Nome {Nome}");
            Console.WriteLine($"O cliente é {MaiorDeIdade}");
            Console.WriteLine($"Senioridade {Contato}");
        }
    }
}
