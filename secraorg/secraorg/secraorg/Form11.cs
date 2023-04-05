using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace secraorg
{
    public partial class PESQUISASTRANSFERENCIA : Form
    {
        private MySqlConnection bdConn;
        private DataTable table;

        public PESQUISASTRANSFERENCIA(MySqlConnection conex)
        {
            bdConn = conex;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;


            table = new DataTable();
            table.Columns.Add("RM", typeof(String));
            table.Columns.Add("RA", typeof(String));
            table.Columns.Add("Nome", typeof(String));
            table.Columns.Add("Nascimento", typeof(String));
            table.Columns.Add("Mãe", typeof(String));
            table.Columns.Add("Série", typeof(String));
            table.Columns.Add("Turma", typeof(String));




            IniciarTabela();

        }

        private void IniciarTabela()
        {

            dataGridView1.DataSource = table; //Seta as informações acima na tabela visual
            DataGridViewColumn column = dataGridView1.Columns[0]; // Editando o tamanho da columa dizendo qual é, e em baixo o tamanho dela
            column.Width = 20;

            column = dataGridView1.Columns[2];
            column.Width = 100;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; //Editando o autosize da tabela, para mudar.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String oque = "aluno"; //String usada para pegar qual check esta selecionado

            // Os if's para pegar o nome de qual esta
            if (radioButton1.Checked)
            {
                oque = "rm";
            }
            else if (radioButton2.Checked)
            {
                oque = "nome";
            }
            else if (radioButton3.Checked)
            {
                oque = "nome_mae";

            }


            table.Clear(); // Limpando o estado atual da tabela, para não misturar os itens

            //Se estiver, realiza um select
            var sqlcode = new MySqlCommand("Select * from aluno where " + oque + " like '%" + pesquisa.Text + "%'", bdConn); //O comando usado do banco
            MySqlDataReader pesq = sqlcode.ExecuteReader(); //executa o comando acima
            while (pesq.Read())
            {
                table.Rows.Add(pesq["rm"].ToString(), pesq["ra"].ToString(), pesq["nome"].ToString(),
                          pesq["data_nascimento"].ToString(), pesq["nome_mae"].ToString(), pesq["serieS"].ToString(),
                          pesq["turmat"].ToString());

            }

            pesq.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1[0, e.RowIndex].Value.ToString() != "")
                {
                    
                    DECLARATRANSFERE declaracaosimples = new DECLARATRANSFERE(bdConn, dataGridView1[0, e.RowIndex].Value.ToString(), this);
                    table.Clear();
                    declaracaosimples.Show();
                    this.Dispose();
                    
                }
            }      
        }

        private void pesquisa_TextChanged(object sender, EventArgs e)
        {
            pesquisa.CharacterCasing = CharacterCasing.Upper;
        }

        private void PESQUISASTRANSFERENCIA_FormClosing(object sender, FormClosingEventArgs e)
        {
             DECLARATRANSFERE declaracaosimples = new DECLARATRANSFERE(bdConn);
            table.Clear();
            declaracaosimples.Show();
            this.Dispose();
        }

        }

    }

