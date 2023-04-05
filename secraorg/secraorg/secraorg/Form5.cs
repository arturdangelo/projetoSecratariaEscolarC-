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
    public partial class CADASTRARTURMA : Form
    {
        private MySqlConnection bdConn;
      
        public CADASTRARTURMA(MySqlConnection conex)
        {
            bdConn = conex;
            InitializeComponent();
        }

        

        

        private void usuárioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CADASTRARUSUARIO cadastrousuario = new CADASTRARUSUARIO(bdConn);
            cadastrousuario.ShowDialog();
        }

        private void alunoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CADASTRARALUNO cadastroaluno = new CADASTRARALUNO(bdConn, this);
            cadastroaluno.ShowDialog();
        }

        private void professorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CADASTRARPROFESSOR cadastroprofessor = new CADASTRARPROFESSOR(bdConn);
            cadastroprofessor.ShowDialog();
        }

        private void turmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PESQUISARALUNO pesquisaaluno = new PESQUISARALUNO();
            pesquisaaluno.ShowDialog();
        }

        private void declaraçãoSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DECLARACAOSIMPLES declaracaosimples = new DECLARACAOSIMPLES(bdConn);
            declaracaosimples.ShowDialog();
        }

        private void passeProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DECLARATRANSFERE declaratransfere = new DECLARATRANSFERE(bdConn);
            declaratransfere.ShowDialog();
        
        }

        private void háVagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DECLARAVAGAS declaravagas = new DECLARAVAGAS(bdConn);
            declaravagas.ShowDialog();
        }

        private void CADASTRARTURMA_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Verifica se a conexão está aberta
            if (bdConn.State == ConnectionState.Open)
            {
                String usuario = txtusu.Text;
                //Se estiver aberta insere os dados na BD
                MySqlCommand commS = new MySqlCommand("INSERT INTO turma VALUES('"+usuario+"','b','b','b','b','b')", bdConn);
                commS.BeginExecuteNonQuery();
            }
        }

        
        private void txtnumerosala_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 08) || (e.KeyChar == 127)))
            {
                e.Handled = true;
            } 
        }
    }
}
