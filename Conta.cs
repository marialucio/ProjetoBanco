public class Conta
{
    public int Codigo { get;}
    public double Saldo { get; private set;}

    public Conta(int codigo)
    {
        Codigo = codigo;
        Saldo = 0.0;
    }

    public void Sacar(double valor)
    {
        ValidarValor(valor);
        VeriricarSaldo(valor);
        Saldo -= valor;
    }

    public void Depositar(double valor)
    {     
        ValidarValor(valor);
        Saldo += valor;
    }

    public void Transferir(double valor, Conta conta)
    {
        conta.Depositar(valor);
        Sacar(valor);
    }

    private void ValidarValor(double valor)
    {
        if (valor <= 0.0) throw new ArgumentException("Valor inválido. Informe um valor positivo.");
    }

    private void VeriricarSaldo(double valor)
    {
        if (valor > Saldo) throw new ArgumentException("Saldo insuficiente. Informe um valor menor que o saldo.");
    }
}