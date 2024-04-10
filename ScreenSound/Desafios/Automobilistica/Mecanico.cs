
namespace ScreenSound.Desafios.Automobilistica
{
    internal class Mecanico(string nome, string especialidade, int anosDeCarreira)
    {
        public string Nome { get; } = nome;
        public string Especialidade { get; } = especialidade;
        private int AnosDeCarreira { get; } = anosDeCarreira;
        // De acordo com os anos de Carreira
        public string Senioridade => AnosDeCarreira < 3 ? "Junior" : "Senior";

        public void InfoMecanico()
        {
            Console.WriteLine("Informações do mecanico:");
            Console.WriteLine($"Nome {Nome}");
            Console.WriteLine($"Especialidade {Especialidade}");
            Console.WriteLine($"Senioridade {Senioridade}");
        }
    }
}
