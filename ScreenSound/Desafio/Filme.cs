namespace Alura.Filmes;

public class Filme
{
    public string Titulo { get; set; }
    public List<string> Elenco { get; set; }
    public int Duracao { get; set; }

    public Filme(string titulo, int duracao, List<string>? elenco)
    {
        if (elenco == null)
        {
            Elenco = new List<string>();
        }
        else
        {
            Elenco = elenco;
        }

        Titulo = titulo;
        Duracao = duracao;
    }

    public void AdicionarElenco(string ator)
    {
        Elenco.Add(ator);
        Console.WriteLine($"{ator} adicionado/a ao elenco.");
    }

    public void ListarElenco()
    {
        if (Elenco.Count == 0)
        {
            Console.WriteLine("Elenco vazio.");
        }
        else
        {
            Console.WriteLine("Elenco... ");
            foreach (var ator in Elenco)
            {
                Console.WriteLine(ator);
            }
        }
    }
}