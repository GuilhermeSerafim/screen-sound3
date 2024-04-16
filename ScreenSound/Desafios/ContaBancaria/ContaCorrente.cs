namespace ScreenSound.Desafios.ContaBancaria;

internal class ContaCorrente : Conta
{
    public bool EhBancoParceiro { get; set; }
    public override void Sacar()
    {
        if (EhBancoParceiro)
        {
            base.Sacar();
        } else
        {
            Saldo -= 20; // Desconto
            base.Sacar();
        }
    }
}
