using System.Drawing;
using TrabalhoDV.Classes;
using TrabalhoDV.Factory;

Console.WriteLine("Bem vindo ao Banco Pitagoras");
Console.WriteLine();

CorrenteFactory Conta_Davi_M = new CorrenteFactory();
PoupançaFactory Conta_Davi_N = new PoupançaFactory();

Conta Conta_Davi_C = new Conta(2500.00, 9375, 6234-9);
Conta Conta_Davi_P = new Conta(30000.00, 1234, 9876 - 5);

Console.WriteLine("Seu saldo atual da sua conta corrente é: " + Conta_Davi_C.saldo);


Console.WriteLine(Conta_Davi_M.Deposito(Conta_Davi_C, 60));
Console.WriteLine("Seu saldo atual é: " + Conta_Davi_C.saldo);

Console.WriteLine(Conta_Davi_M.Saque(Conta_Davi_C, 50));
Console.WriteLine("Seu saldo atual é: " + Conta_Davi_C.saldo);

Console.WriteLine(Conta_Davi_M.Transferencia(Conta_Davi_C, Conta_Davi_P,100.00));
Console.WriteLine("Seu saldo atual é: " + Conta_Davi_C.saldo);

Console.WriteLine();

Console.WriteLine("Seu saldo atual da sua conta poupança é: " + Conta_Davi_P.saldo);

Console.WriteLine(Conta_Davi_N.Deposito(Conta_Davi_P, 6000));
Console.WriteLine("Seu saldo atual é: " + Conta_Davi_P.saldo);

Console.WriteLine(Conta_Davi_N.Saque(Conta_Davi_P, 10000));
Console.WriteLine("Seu saldo atual é: " + Conta_Davi_P.saldo);

Console.WriteLine(Conta_Davi_N.Transferencia(Conta_Davi_P, Conta_Davi_C, 5000.00));
Console.WriteLine("Seu saldo atual é: " + Conta_Davi_P.saldo);



