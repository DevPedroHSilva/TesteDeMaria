using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DataBase
{
    /// <summary>
    ///    Essa classe eu fiz pensando em concetrar em um lugar tudo que é relacionado a comunicação
    ///    com o banco de dados, ao meu ver fica mais intuitivo usar dessa maneira.
    /// </summary>
    public class Conexao
    {
        private string str_connection = "Host=localhost;Username=\"postgres\";Password=0904;Database=\"db_TesteDeMaria\"";
        private NpgsqlConnection connection;
        public List<object> Parameters = new List<object>();


        public Conexao() { }


        /// <summary>
        /// Método exclusivo para abrir conexão (Comando interno)
        /// </summary>
        internal void abrirConexao()
        {
            connection = new NpgsqlConnection(str_connection);
            connection.Open();
        }


        /// <summary>
        /// Método exclusivo para fechar conexão (Comando Publico)
        /// </summary>
        public void encerrarConexao()
        {
            if (connection != null) connection.Close();
        }



        /// <summary>
        /// Método para auxiliar os facilitadores de interação com SQL
        /// </summary>
        /// <param name="str_sql"></param>
        /// <returns></returns>
        NpgsqlCommand Command (string str_sql)
        {
            NpgsqlCommand command = new NpgsqlCommand(str_sql, connection);

            if (Parameters != null)
            {
                foreach (dynamic parameter in Parameters)
                {
                    string chr_campo = parameter.chr_campo;
                    string chr_valor = parameter.chr_valor;

                    command.Parameters.AddWithValue(chr_campo, chr_valor);
                }

                Parameters.Clear();
            }

            return command;
        }



        /// <summary>
        /// Método que adiciona parametros para serem usados impedindo sqlInject.
        /// </summary>
        /// <param name="chr_campo"></param>
        /// <param name="chr_valor"></param>
        public void prm(string chr_campo, string chr_valor)
        {
            Parameters.Add(new
            {
                chr_campo = chr_campo,
                chr_valor = chr_valor
            });
        }








        //Métodos facilitadores para comunicação com SQL


        /// <summary>
        /// Método que padroniza e facilita qualquer interação com banco, principalmente usado para Selects
        /// </summary>
        /// <param name="str_sql"></param>
        /// <returns></returns>
        public NpgsqlDataReader Ndr(string str_sql)
        {
            abrirConexao();
            NpgsqlCommand command = Command(str_sql);
            NpgsqlDataReader Ndr = command.ExecuteReader(CommandBehavior.CloseConnection);
            return Ndr;
        }


        /// <summary>
        /// Método utilizado para interagir com sql, principalmete utilizado para melhorar o empenho de loops e condições de registros, ao inves de chamar varias conexões no banco, chama apenas uma.
        /// </summary>
        /// <param name="str_sql"></param>
        /// <returns></returns>
        public DataTable DataTable(string str_sql)
        {
            abrirConexao();
            NpgsqlCommand command = Command(str_sql);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            encerrarConexao();

            return dataTable;
        }



        /// <summary>
        /// Método utilizado quando é necessario trazer apenas 1 ou uma linha de registro trabalhando com o type DataRow
        /// </summary>
        /// <param name="str_sql"></param>
        /// <returns></returns>
        public DataRow DataRow(string str_sql)
        {
            DataRow dr = null;
            DataTable dt = DataTable(str_sql);

            if (dt.Rows.Count > 0 && dt != null)
            {
                dr = dt.Rows[0];
            }

            return dr;
        }

    }
}
