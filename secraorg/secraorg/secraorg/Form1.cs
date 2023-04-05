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
    public partial class PESQUISARALUNO : Form
    {
        private MySqlConnection bdConn; //Conexão com o banco de dados
       
        private DataSet bdDataSet; //MySQL
        private DataTable table;
        

        public PESQUISARALUNO()  
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            

            
                   
            //Definição do dataset
            bdDataSet = new DataSet();
             //Define string de conexão
            bdConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=secraorg;uid=root;pwd=''");
            
            
           


            //Abre conexão
            try{
 	            bdConn.Open();
            }
            catch{
                MessageBox.Show("Impossível estabelecer conexão");
            }

            

            table = new DataTable();
            table.Columns.Add("RM",typeof(String));
            table.Columns.Add("RA",typeof(String));
            table.Columns.Add("Nome",typeof(String));
            table.Columns.Add("Nascimento",typeof(String));
            table.Columns.Add("Mãe", typeof(String));
            table.Columns.Add("Série", typeof(String));
            table.Columns.Add("Turma", typeof(String));
            
            
            
            
            IniciarTabela();
        }

        

        private void IniciarTabela()
        {
             //Se estiver, realiza um select
          /*  var sqlcode = new MySqlCommand("Select * from aluno", bdConn); //O comando usado do banco
            MySqlDataReader pesq = sqlcode.ExecuteReader(); //executa o comando acima
            while (pesq.Read())
                  {  //seta as informações puxadas do banco na tabela
                      table.Rows.Add(pesq["rm"].ToString(), pesq["ra"].ToString(), pesq["nome"].ToString(), 
                          pesq["data_nascimento"].ToString(), pesq["nome_mae"].ToString(),pesq["serieS"].ToString(),
                          pesq["turmat"].ToString());
            }

            pesq.Close();*/ // fecha a conexão com o bd.

            dataGridView1.DataSource = table; //Seta as informações acima na tabela visual
             DataGridViewColumn column = dataGridView1.Columns[0]; // Editando o tamanho da columa dizendo qual é, e em baixo o tamanho dela
            column.Width =20;

            column = dataGridView1.Columns[2];
            column.Width = 100;

             dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; //Editando o autosize da tabela, para mudar.
        }

        

        private void usuárioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {


            this.Hide();
            CADASTRARUSUARIO cadastrousuario = new CADASTRARUSUARIO(bdConn);
            cadastrousuario.ShowDialog();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CADASTRARALUNO cadastroaluno = new CADASTRARALUNO(bdConn, this);
            table.Clear();
            cadastroaluno.Show();
        }

        private void turmaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CADASTRARTURMA cadastroturma = new CADASTRARTURMA(bdConn);
            cadastroturma.ShowDialog();
        }

        private void professorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CADASTRARPROFESSOR cadastroprofessor = new CADASTRARPROFESSOR(bdConn);
            cadastroprofessor.ShowDialog();
        }

        private void declaraçãoSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DECLARACAOSIMPLES declaracaosimples = new DECLARACAOSIMPLES(bdConn);
            declaracaosimples.Show();
            
        }

        private void passeProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DECLARATRANSFERE declaratransfere = new DECLARATRANSFERE(bdConn);
            declaratransfere.Show();
        }

        private void háVagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DECLARAVAGAS declaravagas = new DECLARAVAGAS(bdConn);
            declaravagas.ShowDialog();
        }

        private void PESQUISARALUNO_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void PESQUISARALUNO_Load(object sender, EventArgs e)
        {
            txtusu.Enabled = false;
            usuárioToolStripMenuItem.Enabled = false;
            turmaToolStripMenuItem.Enabled = false;
            professorToolStripMenuItem.Enabled = false;
            declaraçãoSimplesToolStripMenuItem.Enabled = true;
            transferenciaToolStripMenuItem.Enabled = true;
            háVagasToolStripMenuItem.Enabled = false;
            prontuárioToolStripMenuItem.Enabled = false;
            prontuárioToolStripMenuItem1.Enabled = false;
            configuraçõesToolStripMenuItem.Enabled = false;
        }

        private void bttpesq_Click(object sender, EventArgs e)
        {
            

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void pesquisa_TextChanged(object sender, EventArgs e)
        {
            pesquisa.CharacterCasing = CharacterCasing.Upper;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1[0, e.RowIndex].Value.ToString() != "")
                {
                    this.Hide();
                    CADASTRARALUNO exibealuno = new CADASTRARALUNO(bdConn, dataGridView1[0, e.RowIndex].Value.ToString(), this);
                    table.Clear();
                    exibealuno.Show();
                }            
            }      
        }

       
        
    }
}
