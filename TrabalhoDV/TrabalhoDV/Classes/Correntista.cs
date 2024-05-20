using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDV.Classes
{
    internal class Correntista : Conta
    {

        public double Codigo;
        public String Nome;
        public double CPF;
        public double Telefone;

        public Correntista()
        {
        }

        public Correntista(double saldo, double agencia, int numero_C) : base(saldo, agencia, numero_C)
        {
        }

        public Correntista(double codigo, string nome, double cPF, double telefone)
        {
            Codigo = codigo;
            Nome = nome;
            CPF = cPF;
            Telefone = telefone;
        }

 
    }
}
