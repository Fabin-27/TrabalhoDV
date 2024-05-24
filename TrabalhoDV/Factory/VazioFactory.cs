using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoDV.Conexoes;

namespace TrabalhoDV.Factory
{
    internal class VazioFactory
    {
        private Banco banco;

        public VazioFactory(Banco banco)
        {
            this.banco = banco;
        }

        public class vazioFactory
        {
            public Banco banco;
            public const string connectionString = "Data Source=InMemorySample;Mode=Memory;Cache=Shared";

            public Boolean ExecuteSql(String sql)
            {
                return banco.ExecuteSql(sql);
            }

            public vazioFactory(Banco banco)
            {
                this.banco = banco;
            }
        }
    }
}
