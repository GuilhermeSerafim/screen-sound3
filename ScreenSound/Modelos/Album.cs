// Um namespace é um contêiner que agrupa um conjunto de classes, structs, interfaces, enums e outros namespaces relacionados logicamente.
// Ele é usado para organizar e evitar conflitos de nome entre os tipos em um projeto.
namespace ScreenSound.Modelos;

    class Album
    {
        public Album(string nome) => Nome = nome;

        private List<Musica> musicas = new List<Musica>();
        public string Nome { get; }
        public int DuracaoTotal => musicas.Sum(musica => musica.Duracao); //     Soma das músicas

        public void AdicionarMusica(Musica musica)
        {
            // Posso adicionar lógicas internas aqui
            musicas.Add(musica);
        }

        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"Exibindo músicas do album {Nome}:\n");
            foreach (var musica in musicas)
            {
                Console.WriteLine($"Música: {musica.Nome}");
            }
            Console.WriteLine($"Duração total em segundos do álbum {Nome}: {DuracaoTotal}s");
        }
    }