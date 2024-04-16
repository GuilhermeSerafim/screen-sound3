namespace ScreenSound.Desafios.EmpresaTech;

internal class ScrumMaster : Funcionario
{
    public List<string> Certificacoes { get; }
    public string MetodoDeTrabalho { get; }

    public ScrumMaster(string nome, List<string> certificacoes, string metodoDeTrabalho)
    {
        Nome = nome;
        Setor = "TI";
        Certificacoes = certificacoes;
        MetodoDeTrabalho = metodoDeTrabalho;
    }

    public void DescricaoScrumMaster()
    {
        Console.WriteLine($"O Scrum Master {Nome}");
        Console.WriteLine("Possui as seguintes certificações:");
        foreach (var certificacao in Certificacoes)
        {
            Console.WriteLine("- " + certificacao);
        }
        Console.WriteLine($"Utiliza o método de trabalho {MetodoDeTrabalho}");
    }
}
