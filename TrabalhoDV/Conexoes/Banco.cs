using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDV.Conexoes
{
    internal class Banco
    {

        public SqliteConnection Connection;

        public const string connectionString = "Data Source=InMemorySample;Mode=Memory;Cache=Shared";

        public Boolean ExecuteSql(String sql) {

            try 
            {
                var createdCommand = Connection.CreateCommand();
                createdCommand.CommandText = sql;

                createdCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception e) 
            {
                return false;
            }
        }

        public Banco() 
        {
            this.Connection = new SqliteConnection(connectionString);
            Connection.Open();

            var createCommand = Connection.CreateCommand();
            createCommand.CommandText = """
    CREATE TABLE DadosBancarios (
        codigo Number,
        Nome TEXT
    )
""";
            createCommand.ExecuteNonQuery();
        }
    }
}
























/* public void ExecutarConsulta()
{

    

    using var conexão = new SqliteConnection(conectarMemoria);
    conexão.Open();

    var ComandoCriar = conexão.CreateCommand();
    ComandoCriar.CommandText = @"
    CREATE TABLE IF NOT EXISTS DadosBancarios (
    Nome TEXT,
    CPF TEXT,
    Agencia TEXT,
    Numero_Conta TEXT,
    Saldo TEXT
    )
    ";

    ComandoCriar.ExecuteNonQuery();

    using (var insertConnection = new SqliteConnection(conectarMemoria)) // perguntar
    {
        insertConnection.Open();

        var ComandoAtualizar = insertConnection.CreateCommand();
        ComandoAtualizar.CommandText = @"
        INSERT INTO DadosBancarios (nome, CPF, Agencia, Numero_Conta, Saldo)
        VALUES ('', '', '', '', ''),
               ('', '', '', '', ''),

        ";
        ComandoAtualizar.ExecuteNonQuery();


    }
}*/

