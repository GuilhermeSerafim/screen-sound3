namespace ScreenSound.Desafios.EmpresaTech;

internal class Programador : Funcionario
{
    public List<string> Linguagens { get; }
    public List<string> FrameworksELibs = new();
    public string NivelExperiencia { get; }

    public Programador(string nome, List<string> linguagens, List<string>? frameworksELibs, string nivelExperiencia)
    {
        Nome = nome;
        Setor = "TI";
        Linguagens = linguagens;
        if (frameworksELibs != null)
        {
            FrameworksELibs = frameworksELibs;
        }
        NivelExperiencia = nivelExperiencia;
    }

    public void DescricaoTecnicaProgramador()
    {
        // Nome veio da classe Ascendente
        Console.WriteLine($"O(A) programador {Nome}, cuja experiência é {NivelExperiencia} ");
        Console.WriteLine("Tem como especialidade as linguagens:\n ");
        foreach (var item in Linguagens) { Console.WriteLine("Linguagem: " + item + "\n"); }
        if (FrameworksELibs.Count != 0)
        {
            Console.WriteLine("E os Frameworks e Libs:\n ");
            foreach (var item in FrameworksELibs) { Console.WriteLine(item + "\n"); }
        }
        else
        {
            Console.WriteLine("Não possue Framework");
        }
    }
}

