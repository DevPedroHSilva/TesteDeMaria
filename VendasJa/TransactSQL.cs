using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using Npgsql;

/// <summary>
/// Essa classe foi idealizada para concentrar e facilitar todas as interações com o banco.
/// Ela centraliza correções, impede sql inject isso é para facilitar o uso e a manutenção do projeto, 
/// sendo assim fazendo em menor tempo.
/// </summary>
public class TransactSQL
{
    ///Lists
    public List<object> list_campos = new List<object>();
    public List<object> list_where = new List<object>();


    ///Ações
    private bool acao_insert = false;
    private bool acao_update = false;
    private bool acao_delete = false;


    ///Instruções
    public string str_instrucao_sql = "";
    private string str_instrucao_where = "";

    Conexao c = new Conexao();

    public void add(string campo, string valor, bool ehTexto = true)
    {
        list_campos.Add(new
        {
            campo = campo,
            valor = valor,
            ehTexto = ehTexto
        });
    }


    public void where(string campo, string valor, bool ehTexto = true)
    {
        list_where.Add(new
        {
            campo = campo,
            valor = valor,
            ehTexto = ehTexto
        });
    }


    private void construirWhere()
    {
        StringBuilder sb_where = new StringBuilder();


        if (list_where.Count > 0)
        {
            sb_where.AppendLine(" WHERE 1=1");

            foreach (dynamic obj in list_where)
            {
                string campo = "" + obj.campo;
                string valor = "" + obj.valor;
                bool ehTexto = obj.ehTexto;

                if (ehTexto)
                    sb_where.AppendLine(" and " + campo + " = '" + valor + "'");
                else
                    sb_where.AppendLine(" and " + campo + " = " + valor);

            }

            str_instrucao_where = sb_where.ToString();
        }
        else
        {
            //Sem ação para esse caso
        }
    }

    public void insert(string tabela, bool bl_ultimo_registro = true)
    {
        c = new Conexao();
        acao_insert = true;

        StringBuilder sb_insert = new StringBuilder();
        sb_insert.AppendLine("INSERT INTO ");
        sb_insert.AppendLine(tabela);
        sb_insert.AppendLine(" (");

        //Loop para montar os campos
        foreach (dynamic obj in list_campos)
        {
            string campo = "" + obj.campo;
            string separador = obj == list_campos.Last() ? "" : ","; //Se for o ultimo objeto do loop ele não adiciona a virgula
            sb_insert.AppendLine(campo + separador);
        }

        sb_insert.AppendLine(") ");
        sb_insert.AppendLine("Values ");
        sb_insert.AppendLine(" (");

        //Loop para montar os campos
        foreach (dynamic obj in list_campos)
        {
            string campo = "" + obj.campo;
            string valor = "" + obj.valor;
            bool ehTexto = obj.ehTexto;
            string separador = obj == list_campos.Last() ? "" : ","; //Se for o ultimo objeto do loop ele não adiciona a virgula

            if (campo.Contains("chr_") && ehTexto)
            {
                c.prm("@" + campo, valor);
                valor = "@" + campo + "";
            }
            else if (campo.Contains("dt_"))
            {
                c.prm("@" + campo, valor);
                valor = "TO_DATE(@" + campo + ", 'YYYY-MM-DD')";
            }
            else if (campo.Contains("flo_"))
            {
                valor = valor.Replace(".", "").Replace(",", "."); //Altera o valor para não bugar a linha de insert
            }


            sb_insert.AppendLine(valor + separador);
        }
        sb_insert.AppendLine("); ");

        if (bl_ultimo_registro)
            sb_insert.AppendLine(" SELECT LASTVAL(); ");



        str_instrucao_sql = sb_insert.ToString();
    }


    public void update(string tabela)
    {
        acao_update = true;
        c = new Conexao();

        StringBuilder sb_update = new StringBuilder();
        sb_update.AppendLine("UPDATE ");
        sb_update.AppendLine(tabela);
        sb_update.AppendLine(" SET ");

        // Loop para montar os campos
        foreach (dynamic obj in list_campos)
        {
            string campo = "" + obj.campo;
            string valor = "" + obj.valor;
            bool ehTexto = obj.ehTexto;
            string separador = obj == list_campos.Last() ? "" : ","; // Se for o último objeto do loop ele não adiciona a vírgula

            if (campo.Contains("chr_") && ehTexto)
            {
                c.prm("@" + campo, valor);
                valor = "@" + campo + "";
            }
            else if (campo.Contains("dt_"))
            {
                c.prm("@" + campo, valor);
                valor = "TO_DATE(@" + campo + ", 'YYYY-MM-DD')";
            }

            sb_update.AppendLine(campo + " = " + valor + separador);
        }

        // Adiciona a cláusula WHERE
        construirWhere();

        if (!str_instrucao_where.Equals(""))
        {
            sb_update.AppendLine(str_instrucao_where);
        }
        else
        {
            // Sem cláusula WHERE, atualiza todos os registros
        }

        str_instrucao_sql = sb_update.ToString();
    }


    public void delete(string tabela)
    {
        acao_delete = true;
        construirWhere();

        StringBuilder sb_delete = new StringBuilder();
        sb_delete.AppendLine("DELETE FROM ");
        sb_delete.AppendLine(tabela);
        if (!str_instrucao_where.Equals(""))
            sb_delete.AppendLine(str_instrucao_where);

        str_instrucao_sql = sb_delete.ToString();
    }


    public string exec()
    {
        string retorno = null;
        if (!str_instrucao_sql.Equals(""))
        {
            NpgsqlDataReader ndr = c.Ndr(str_instrucao_sql);
            if (ndr.Read())
            {
                if (acao_insert)
                {
                    //Retorna o ID que acabou de ser inserido!
                    retorno = "" + ndr[0];
                }
            }
        }
        else
        {
            //Sem ação para esse caso de uso!
        }


        return retorno;
    }

}
