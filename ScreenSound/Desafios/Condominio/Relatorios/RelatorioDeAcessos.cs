using RegistroDeAcesso.Modelos;

namespace RegistroDeAcesso.Relatorios;

internal class RelatorioDeAcesso
{
    private List<AcessoAoPredio> acessos = new();
    // Usando interface como parametro
    //  A classe RelatorioDeAcesso não precisa conhecer os detalhes específicos da implementação de Resumo.
    //  Ela só precisa saber que qualquer objeto que implemente IResumoAcesso terá uma propriedade Resumo que pode ser acessada.
    public void RegistrarEntrada(IResumoAcesso entrada)
    {
        acessos.Add(new AcessoAoPredio(DateTime.Now, entrada.Resumo));
    }

    public void ExibirRegistroDoMes()
    {
        Console.WriteLine("Acessos registrados no mês:");
        foreach (var acesso in acessos)
        {
            Console.WriteLine($"- {acesso.Resumo} em {acesso.Entrada}");
        }
    }
}
