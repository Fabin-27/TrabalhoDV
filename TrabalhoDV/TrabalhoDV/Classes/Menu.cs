using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoDV.Factory;

namespace TrabalhoDV.Classes
{
    class Menu
    {
        bool loope1 = true;
        bool loope2 = true;
        bool loope3 = true;
        bool loope4 = true;
        
        CorrenteFactory Conta_Davi_M = new CorrenteFactory();
        PoupançaFactory Conta_Davi_N = new PoupançaFactory();

        Conta Conta_Davi_C = new Conta(2500.00, 9375, 6234 - 9);
        Conta Conta_Davi_P = new Conta(30000.00, 1234, 9876 - 5); 

        

        public void Inicializar()
        {
            
            Console.WriteLine("Bem vindo ao Banco Pitagoras");
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine();
            Console.WriteLine("(1) Operações");
            Console.WriteLine("(2) Correntista");
            Console.WriteLine("(3) Conta");
            Console.WriteLine("(0) Sair");

            int a = int.Parse(Console.ReadLine());

            while (a != 0)
            {

                switch (a)
                {

                    case 1:

                        

                        while (loope1)
                        {

                            Console.WriteLine("Escolha a conta que deseja operar:");
                            Console.WriteLine("(1) Corrente");
                            Console.WriteLine("(2) Poupança");
                            Console.WriteLine("(3) Voltar");

                            int z = int.Parse(Console.ReadLine());
                            double y;
                            loope2 = true;

                            while (loope2)
                            {

                                switch (z)
                                {

                                    case 1:
                                        Console.WriteLine("Escolha a operação desejada");
                                        Console.WriteLine();
                                        Console.WriteLine("(1) deposito");
                                        Console.WriteLine("(2) Saque");
                                        Console.WriteLine("(3) transferencia entre contas");
                                        Console.WriteLine("(4) mudar de conta");
                                        Console.WriteLine("(5) sair");

                                        int x = int.Parse(Console.ReadLine());

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
                                                loope1 = false;

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

                                                Console.WriteLine("Digite quanto deseja transferir para a conta corrente: ");
                                                y = double.Parse(Console.ReadLine());
                                                Conta_Davi_M.Transferencia(Conta_Davi_P, Conta_Davi_C, y);
                                                Console.WriteLine("Seu saldo atual é: " + Conta_Davi_P.saldo);

                                                break;

                                            case 4:

                                                loope2 = false;

                                                break;

                                            case 5:

                                                loope2 = false;
                                                loope1 = false;

                                                break;
                                        }

                                        break;

                                    case 3:

                                        Inicializar();

                                        break;

                                }



                            }
                        }

                        break;

                    case 2:

                        OpçãoCorentista();

                        break;

                    case 3:

                        Console.WriteLine("Informações Bnacárias: ");

                        Console.WriteLine("");



                        break;

                }

            }

        }

        private void OpçãoCorentista()
        {

            while (loope3)
            {

                Console.WriteLine("Menu Correntista:");
                Console.WriteLine();
                Console.WriteLine("(1) Cadastrar");
                Console.WriteLine("(2) Editar");
                Console.WriteLine("(3) Excluir");
                Console.WriteLine("(4) Voltar");

                int b = int.Parse(Console.ReadLine());

                switch (b)
                {
                    case 1:

                        CadastrarCorrentista();

                        break;

                    case 2:

                        EditarCorrentista();

                        break;

                    case 3:

                        ExcluirCorrentista();

                        break;

                    case 4:

                        Inicializar();

                        break;
                }

            }

        }
        private void CadastrarCorrentista()
        {

            Correntista ct = new Correntista();
            Console.WriteLine("Informe o código");
            ct.Codigo = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Nome");
            ct.Nome = Console.ReadLine();
            Console.WriteLine("Informe o CPF");
            ct.CPF = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Telefone");
            ct.Telefone = double.Parse(Console.ReadLine());
        }

        private void EditarCorrentista()
        {

            Correntista ct = new Correntista();
            Console.WriteLine("Codigo:" + ct.Codigo);
            Console.WriteLine("Nome: " + ct.Nome);
            Console.WriteLine("Nome: " + ct.CPF);
            Console.WriteLine("Nome: " + ct.Telefone);

            Console.WriteLine("Qual deseja alterar?");
            Console.WriteLine("(1) Telefone");
            Console.WriteLine("(2) Nome");

            int i = int.Parse(Console.ReadLine());

            if (i == 1)
            {
                Console.WriteLine("Digite o novo telefone: ");
                ct.Telefone = double.Parse(Console.ReadLine());
            }
            else if (i == 2)
            {
                Console.WriteLine("Digite o novo Nome: ");
                ct.Nome = Console.ReadLine();
            }

        }

        private void ExcluirCorrentista()
        {

            Correntista ct = new Correntista();
            Console.WriteLine("Digite o cpf do correntista");
            int cpf = int.Parse(Console.ReadLine());

            if (cpf == ct.CPF)
            {
                Console.WriteLine("O correntista " + ct.Nome + " foi excluido com sucesso");
            }
            else
            {
                Console.WriteLine("Correntista inexistente");
            }
        }


    }

}
