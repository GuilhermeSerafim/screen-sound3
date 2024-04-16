namespace ScreenSound.Modelos;

// Assinatura
internal interface IAvaliavel
{
    // Para você assinar o contrato, precisa seguir essa clausula do contrato
    void AdicionarNota(Avaliacao nota);
    double Media { get; }
}
