namespace Alura.Filmes
{

    public class Artista
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Filme> FilmesAtuados { get; set; }
        public int QuantidadeDeFilmes => FilmesAtuados.Count;


        public Artista(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            FilmesAtuados = new List<Filme>();
        }


        public void AdicionarFilmeAtuado(Filme filme)
        {
            // This - Artista
            if (this.FilmesAtuados.Contains(filme))
            {
                Console.WriteLine($"O artista {this.Nome} já está no elenco do Filme {filme.Titulo}\n");
            }
            else
            {
                // Consistência com a classe Filme
                FilmesAtuados.Add(filme); // Adicionando filme atuado (consistencia)
                filme.Elenco.Add(this); // Adicionando artista ao elenco
            }
        }

        public void MostrarFilmesAtuados()
        {

            if (this.FilmesAtuados.Count == 0)
            {
                Console.WriteLine($"Nenhum filme encontrado na base para {this.Nome}");
                return;
            }

            Console.WriteLine($"O {this.Nome} atuou em {this.QuantidadeDeFilmes} Filmes...");
            foreach (var filme in FilmesAtuados)
            {
                Console.WriteLine($"Filme: {filme.Titulo}");
            }
        }
    }
}