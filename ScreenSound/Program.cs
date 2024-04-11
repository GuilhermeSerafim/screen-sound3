// A declaração using é para usar o namespace sem declarar o mesmo toda vez
using ScreenSound.Menus;
using ScreenSound.Modelos;

// Bandas iniciais
Banda iraInicial = new("Ira!");
iraInicial.AdicionarNota(new Avaliacao(8));
iraInicial.AdicionarNota(new Avaliacao(9));
iraInicial.AdicionarNota(new Avaliacao(10));
Banda beatlesInicial = new("The Beatles");

// Dictionary<TKey, TValue>
// Ou seja a chave seria o nome da banda (disponivel no construtor) e o valor seria o objeto banda, no qual teremos acesso aos metodos, entre outros
Dictionary<string /*Nome da banda*/, Banda/*Propriedades da banda*/> bandas = new();
bandas.Add(iraInicial.Nome, iraInicial);
bandas.Add(beatlesInicial.Nome, beatlesInicial);

Menu menu = new Menu();
menu.ExibirOpcoesDoMenu(bandas);