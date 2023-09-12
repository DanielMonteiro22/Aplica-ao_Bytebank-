using bytebank.Contas;
using bytebank.Titular;

//ContaCorrente contaDoDaniel = new ContaCorrente();
//contaDoDaniel.titular = "Daniel Monteiro";
//contaDoDaniel.numero_agencia = 15;
//contaDoDaniel.conta = "1010-X";
//contaDoDaniel.saldo = 100;

//Console.WriteLine("Saldo da conta do Daniel= " + contaDoDaniel.saldo);

//contaDoDaniel.Depositar(100);

//Console.WriteLine("Saldo da conta do Daniel pos-deposito = " + contaDoDaniel.saldo);

//if (contaDoDaniel.Sacar(300) == true)
//{
//    Console.WriteLine("Saldo da conta do Daniel pos-saque = " + contaDoDaniel.saldo);
//}
//else
//{
//    Console.WriteLine("Saldo insuficiente para saque");
//}

//ContaCorrente ContaCamila = new ContaCorrente();
//ContaCamila.titular = "Camila Nascimento";
//ContaCamila.numero_agencia = 17;
//ContaCamila.conta = "1010-5";
//ContaCamila.saldo = 350;

//Console.WriteLine("Saldo da conta da  Camila = " + ContaCamila.saldo);

//contaDoDaniel.Transferir(50, ContaCamila);
//Console.WriteLine("Saldo do Daniel= " + contaDoDaniel.saldo);
//Console.WriteLine("Saldo da Camila= " + ContaCamila.saldo);


//ContaCorrente ContaSilas = new ContaCorrente();

//ContaSilas.titular = "Silas Lebre";

//Console.WriteLine(ContaSilas.titular);
//Console.WriteLine(ContaSilas.saldo);
//Console.WriteLine(ContaSilas.numero_agencia);
//Console.WriteLine(ContaSilas.conta);

//Cliente cliente = new Cliente();
//cliente.nome = "Daniel Monteiro";
//cliente.cpf = "01724424";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();

//conta.titular = cliente;
//conta.conta = "1010 - x";
//conta.numero_agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular: "+ conta.titular.nome);
//Console.WriteLine("CPF: " + conta.titular.cpf);
//Console.WriteLine("Profissão: " + conta.titular.profissao);
//Console.WriteLine("N Conta: " + conta.conta);
//Console.WriteLine("Saldo: " + conta.saldo);
//Console.WriteLine("N Agencia: "+ conta.numero_agencia);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();

//conta2.titular.nome = "Camila Nascimento";
//conta2.titular.profissao = "Dev";
//conta2.titular.cpf = "837489346";
//conta2.conta = "9999-x";
//conta2.numero_agencia = 17;
//conta2.saldo = 10000;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_agencia = 15;
//conta3.conta = "73648-X";
//conta3.SetSaldo(-10);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_agencia);
//Console.WriteLine(conta3.conta);

//ContaCorrente conta4 = new ContaCorrente(18 , "3232-x");
//conta4.SetSaldo(500);
//conta4.titular = new Cliente();
//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);

ContaCorrente conta5 = new ContaCorrente(283, "1234-x") ;
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta6 = new ContaCorrente( 284, "4321-x") ;
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

