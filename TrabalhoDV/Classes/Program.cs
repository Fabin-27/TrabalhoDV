using System.Drawing;
using TrabalhoDV.Classes;
using TrabalhoDV.Factory;

Console.WriteLine("Bem vindo ao Banco Pitagoras");
Console.WriteLine();

CorrenteFactory Conta_Davi_M = new CorrenteFactory();
PoupançaFactory Conta_Davi_N = new PoupançaFactory();

Conta Conta_Davi_C = new Conta(2500.00, 9375, 6234-9);
Conta Conta_Davi_P = new Conta(30000.00, 1234, 9876-5);



bool loope = true;
bool loope2 = true;

while (loope) {

    Console.WriteLine("Escolha a conta que deseja operar:");
    Console.WriteLine("(1) Corrente");
    Console.WriteLine("(2) Poupança");

    int z = int.Parse(Console.ReadLine());
    int x;
    double y;
    loope2 = true;

    while (loope2) {



        switch (z) {

            case 1:
                Console.WriteLine("Escolha a operação desejada");
                Console.WriteLine();
                Console.WriteLine("(1) deposito");
                Console.WriteLine("(2) Saque");
                Console.WriteLine("(3) transferencia entre contas");
                Console.WriteLine("(4) mudar de conta");
                Console.WriteLine("(5) sair");

                x = int.Parse(Console.ReadLine());

                switch (x)
                {

                    case 1:

                        Console.WriteLine("Digite quanto deseja depositar na conta: ");
                        y = double.Parse(Console.ReadLine());

                        Conta_Davi_M.Deposito(Conta_Davi_C, y);
                        Console.WriteLine("Seu saldo atual é: " + Conta_Davi_C.saldo);

                        break;

                    case 2:

                        Console.WriteLine("Digite quanto deseja sacar da conta: ");
                        y = double.Parse(Console.ReadLine());
                        Conta_Davi_M.Saque(Conta_Davi_C, y);
                        Console.WriteLine("Seu saldo atual é: " + Conta_Davi_C.saldo);

                        break;

                    case 3:

                        Console.WriteLine("Digite quanto deseja transferir para a conta popupança: ");
                        y = double.Parse(Console.ReadLine());
                        Conta_Davi_M.Transferencia(Conta_Davi_C, Conta_Davi_P, y);
                        Console.WriteLine("Seu saldo atual é: " + Conta_Davi_C.saldo);



                        break;

                        case 4:

                        loope2 = false;

                        break;

                        case 5:

                        loope2 = false;
                        loope = false;

                        break;
                }

             break;

            case 2:

                Console.WriteLine("Escolha a operação desejada");
                Console.WriteLine();
                Console.WriteLine("(1) deposito");
                Console.WriteLine("(2) Saque");
                Console.WriteLine("(3) transferencia entre contas");
                Console.WriteLine("(4) mudar de conta");
                Console.WriteLine("(5) sair");

                x = int.Parse(Console.ReadLine());

                switch (x)
                {

                    case 1:

                        Console.WriteLine("Digite quanto deseja depositar na conta: ");
                        y = double.Parse(Console.ReadLine());

                        Conta_Davi_M.Deposito(Conta_Davi_P, y);
                        Console.WriteLine("Seu saldo atual é: " + Conta_Davi_P.saldo);

                        break;

                    case 2:

                        Console.WriteLine("Digite quanto deseja sacar da conta: ");
                        y = double.Parse(Console.ReadLine());
                        Conta_Davi_M.Saque(Conta_Davi_P, y);
                        Console.WriteLine("Seu saldo atual é: " + Conta_Davi_P.saldo);

                        break;

                    case 3:

                        Console.WriteLine("Digite quanto deseja transferir para a conta popupança: ");
                        y = double.Parse(Console.ReadLine());
                        Conta_Davi_M.Transferencia(Conta_Davi_P, Conta_Davi_C, y);
                        Console.WriteLine("Seu saldo atual é: " + Conta_Davi_P.saldo);



                        break;

                    case 4:

                        loope2 = false;

                        break;

                    case 5:

                        loope2 = false;
                        loope = false;

                        break;
                }

                break;

                

        }

        

    }
}


