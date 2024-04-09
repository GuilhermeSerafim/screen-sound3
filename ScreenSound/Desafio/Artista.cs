namespace Alura.Filmes;


public class Artista
{
    private string Nome { get; }
    private int Idade { get; }
    private List<Filme> FilmesAtuados { get; set; }
    public int QuantidadeDeFilmes => FilmesAtuados.Count;


    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        FilmesAtuados = new List<Filme>();
    }


    public void AdicionarFilme(string filme)
    {
        FilmesAtuados.Add(filme);
    }

    public void MostrarFilmesAtuados()
    {

        if (this.FilmesAtuados.Count == 0)
        {
            Console.WriteLine($"Nenhum filme encontrado na base para {this.Nome}");
            return;
        }

        Console.WriteLine($"Filmes de {this.Nome}...");
        foreach (var filme in FilmesAtuados)
        {
            Console.WriteLine($"Filme: {filme.Titulo}");
        }
    }
}