using RegistroDeAcesso.Modelos;
using RegistroDeAcesso.Relatorios;

Entrega entregaDePizza = new Entrega(representante: "Marcela");
Colaborador joseDaAlura = new Colaborador(idAcesso: 25);
Colaborador mariaDaAcme = new Colaborador(idAcesso: 14);
Visitante filhoDeMaria = new Visitante(nome: "Pedro", documento: "12938732", sala: "1002");

RelatorioDeAcesso acessoMensal = new RelatorioDeAcesso();

// O método RegistrarEntrada está aceitando objetos do tipo Entrega, Colaborador e Visitante porque essas classes possuem uma característica comum:
// Todas elas fornecem um resumo do acesso através da implementação da interface IResumoAcesso.
acessoMensal.RegistrarEntrada(entregaDePizza);
acessoMensal.RegistrarEntrada(joseDaAlura);
acessoMensal.RegistrarEntrada(mariaDaAcme);
acessoMensal.RegistrarEntrada(filhoDeMaria);
// Portanto, quando chamamos o método RegistrarEntrada passando um objeto Entrega, Colaborador ou Visitante,
// estamos na verdade passando objetos que implementam a interface IResumoAcesso.
// Isso permite que o método RegistrarEntrada acesse a propriedade Resumo desses objetos para registrar as informações relevantes sobre o acesso

// ao final do mês...
acessoMensal.ExibirRegistroDoMes();