using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;
using System.Windows.Forms;
using System.Security.Cryptography;
using VendasJa.Cliente;
using System.Reflection;
using DataBase;


/*
    A ideia dessa classe é facilitar o desenvolvimento, construi ela como se fosse um framework para
    padronização das paginas.

    Se seguir o padrão das outras páginas criar um grande sistema será muito facil, 
    ficara restrito somente a grandes personalizações.

    Também é o ideal para facilitar as possiveis correções em um menor tempo possivel.
    Pode observar que ela não adota nenhum tipo expecifico, foi concebida de maneira genérica, pra realmente 
    atender qualquer tipo de formulario padrão.

    Ela funciona para as seguintes ações nos fomularios:
    Pesquisar;
    Cadastro;
    Edição;
    Exibição;

 */

public class Base
{
    public Form form_pesquisa;
    public Form form_cadastro;
    public Form form_edicao;
    public Form form_exibicao;


    /// <summary>
    /// Adiciona colunas em um gridView com base nos dados de um dataTable e retorna o gridView Passado por paramentro.
    /// </summary>
    /// <param name="dataTable"></param>
    /// <param name="dataGridView"></param>
    /// <returns></returns>
    public DataGridView adicionarColunasGridViewPesquisar(DataTable dataTable, DataGridView dataGridView)
    {

        foreach (DataColumn col in dataTable.Columns)
        {
            string headerText = col.ColumnName;
            //Prefixos utilizados para identificação do typo de armazenagem do campo.
            //headerText = headerText.Replace("id_",""); Id eu deixei para não confundir com o padrão do nome
            headerText = headerText.Replace("chr_", "");
            headerText = headerText.Replace("flo_", "");
            headerText = headerText.Replace("dt_", "");
            headerText = headerText[0].ToString().ToUpper() + headerText.Substring(1);

            dataGridView.Columns.Add(col.ColumnName, headerText);
        }

        return dataGridView;
    }

    /// <summary>
    /// Adiciona colunas de ação e numeral.
    /// </summary>
    /// <param name="dataGridView"></param>
    /// <returns></returns>
    public DataGridView adicionarColunasExtras(DataGridView dataGridView)
    {
        dataGridView.Columns.Add("col_numeric", "*");
        dataGridView.Columns["col_numeric"].Width = 50;
        dataGridView.Columns.Add("col_acao", "Ações");
        return dataGridView;
    }

    /// <summary>
    /// Adiciona resultados aos gridView do formulario de pesquisa, incluindo os botões de edição.
    /// </summary>
    /// <param name="dataTable"></param>
    /// <param name="dataGridView"></param>
    /// <returns></returns>
    public DataGridView adicionarLinhasGridViewPesquisar(DataTable dataTable, DataGridView dataGridView)
    {
        int int_contador = 1;
        foreach (DataRow row in dataTable.Rows)
        {
            int rowIndex = dataGridView.Rows.Add();

            dataGridView.Rows[rowIndex].Cells[0].Value = int_contador;

            for (int colIndex = 2; colIndex < dataTable.Columns.Count; colIndex++)
            {
                dataGridView.Rows[rowIndex].Cells[colIndex].Value = row[colIndex - 2];
            }

            adicionarBotoesAcoes(dataGridView, rowIndex, row[0].ToString());
            int_contador++;
        }
        return dataGridView;
    }

    /// <summary>
    /// Adiciona os botões de edição de cada linha de resultado. Pra cada botão é acionado via tag a session
    /// para que os formularios seguintes reaproveitem os dados.
    /// Feito dessa maneira para ser usado independente do formulario.
    /// </summary>
    /// <param name="dataGridView"></param>
    /// <param name="rowIndex"></param>
    /// <param name="id"></param>
    public void adicionarBotoesAcoes(DataGridView dataGridView, int rowIndex, string id)
    {

        DataGridViewButtonCell btnEditar = new DataGridViewButtonCell();
        btnEditar.Value = "Editar";
        btnEditar.Tag = id;
        dataGridView.Rows[rowIndex].Cells["col_acao"] = btnEditar;

        // Manipulador de evento para o clique do botão
        dataGridView.CellClick += (sender, e) =>
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView.Columns["col_acao"].Index)
            {
                var cell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;

                if (cell != null && cell.Tag != null)
                {
                    string id = "" + cell.Tag;

                    Session.Instance["id"] = id; //adiciona na classe de session para ser usado por formularios futuros como o de edição e exibição

                    form_pesquisa.Hide();
                    form_edicao.Show();
                }
            }
        };
    }

}



/// <summary>
/// Classe auxiliadora para métodos que não necessariamente tem haver com a classe de base pois funciona independente do framwirkBase.
/// Funciona para situações expecificas que podem ser repetidas ao longo do projeto.
/// </summary>
public static class Util
{
    /// <summary>
    /// Busca o caminho base do projeto
    /// </summary>
    /// <returns>
    /// Retorna uma string com o caminho do projeto
    /// </returns>
    public static string retornaCaminhoBaseProjeto()
    {
        string assemblyPath = "" + Assembly.GetEntryAssembly().Location; // Obtém o caminho do assembly principal
        string projectDirectory = "" + Path.GetDirectoryName(Path.GetDirectoryName(assemblyPath)); // Navega dois diretórios acima para chegar ao diretório do projeto
        projectDirectory = projectDirectory.Substring(0, projectDirectory.IndexOf("VendasJa") + "VendasJa".Length); //Deixa o caminho na raiz do projeto.

        return projectDirectory;
    }


    /// <summary>
    /// Salva imagem com base em um ID de banco ou identificador. Sempre vai salvar na pasta IMG da raiz do projeto
    /// </summary>
    /// <param name="id"></param>
    /// <param name="filePath">O path da imagem de origem</param>
    /// <returns>Retorna em string onde foi salvo o arquivo</returns>
    public static string salvarImagemComBaseId(string id, string filePath)
    {
        string targetPath = Path.Combine(Util.retornaCaminhoBaseProjeto(), "IMG", id);

        // Verifique se o diretório existe, se não, crie-o
        if (!Directory.Exists(targetPath))
        {
            Directory.CreateDirectory(targetPath);
        }

        // Obtenha o nome do arquivo
        string fileName = Path.GetFileName(filePath);
        string destFile = Path.Combine(targetPath, fileName);

        // Copie o arquivo para o diretório do projeto
        File.Copy(filePath, destFile, true);

        // Retorne o caminho completo do arquivo salvo
        return destFile;

    }


    /// <summary>
    /// Método para verificar se uma sting é um numero
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static bool IsNumeric(string text)
    {
        foreach (char c in text)
        {
            if (!char.IsDigit(c))
            {
                return false; // Retorna falso se algum caractere não for um dígito
            }
        }
        return true; // Retorna verdadeiro se todos os caracteres forem dígitos
    }




    //Classe resposavel por designar o retorno de um combobox definindo um tipo pra ele.
    public class clsComboBox
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public static void loadDDL(ComboBox ddl, string str_sql, bool obrigatorio = false)
    {
        if (!str_sql.Equals(""))
        {
            Conexao c = new Conexao();
            DataTable dataTable = c.DataTable(str_sql);
            if (dataTable.Rows.Count > 0)
            {
                List<clsComboBox> items = new List<clsComboBox>();

                if (!obrigatorio)
                {
                    items.Add(new clsComboBox
                    {
                        Name = "",
                        Value = ""
                    });
                }

                foreach(DataRow item in dataTable.Rows)
                {
                    items.Add(new clsComboBox
                    {
                        Name = "" + item[1],
                        Value = "" + item[0]
                    });
                }


                //Configurando o comboBox
                ddl.DataSource = items;
                ddl.DisplayMember = "Name";
                ddl.ValueMember = "Value";
            }
            else
            {
                //Sem ação para esse caso de uso!
            }
            c.encerrarConexao();
        }
        else
        {
            //sem ação para esse caso de uso!
        }

    }
    
    public static clsComboBox retornaValorSelecionado(ComboBox ddl)
    {
        clsComboBox comboBox = new clsComboBox();
        if (ddl.SelectedItem is clsComboBox itemSelecionado)
        {
            comboBox.Name = itemSelecionado.Name;
            comboBox.Value = itemSelecionado.Value; 
        }

        return comboBox;
    }


}

