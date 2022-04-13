Conta c1 = new Conta(1);
Conta c2 = new Conta(2);

Console.WriteLine("\n------CONTA 1------\n");

c1.Depositar(1000.00);
c1.Sacar(200.00);

Console.WriteLine("Codigo: {0}", c1.Codigo);
Console.WriteLine("Saldo: {0}", c1.Saldo);

Console.WriteLine("\n------CONTA 2------\n");

c2.Depositar(200.00);
c2.Sacar(150.00);

Console.WriteLine("Codigo: {0}", c2.Codigo);
Console.WriteLine("Saldo: {0}", c2.Saldo);

Console.WriteLine("\n------TRANSFERIR------\n");

c1.Transferir(50.00, c2);

Console.WriteLine("Saldo da conta 1: {0}", c1.Saldo);
Console.WriteLine("Saldo da conta 2: {0}", c2.Saldo);

