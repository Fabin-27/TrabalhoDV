using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoDV.Classes;
using TrabalhoDV.Conexoes;

namespace TrabalhoDV.Factory
{
    internal class CorrentistaFactory
    {
        public CorrentistaFactory(Banco banco)
        {
        }

    

        public class correntistaFactory : VazioFactory
        {
            public correntistaFactory(Banco banco) : base(banco) 
            {
            }

            public bool Salvar(Correntista correntista)
            {
                String sql = String.Format("insert into DadosBancarios (codigo, nome) values (1, Davi)");
                return this.ExecuteSql(sql);
            }

            private bool ExecuteSql(string sql)
            {
                throw new NotImplementedException();
            }
        }
    }
}
