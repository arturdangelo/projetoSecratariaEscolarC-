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
    public partial class CADASTRARPROFESSOR : Form
    {
        private MySqlConnection bdConn;
        
        public CADASTRARPROFESSOR(MySqlConnection conex)
        {
            bdConn = conex;    
            InitializeComponent();
        }

       

     

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CADASTRARALUNO cadastroaluno = new CADASTRARALUNO(bdConn, this);
            cadastroaluno.ShowDialog();

        }

       

        

        private void usuárioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CADASTRARUSUARIO cadastrousuario = new CADASTRARUSUARIO(bdConn);
            cadastrousuario.ShowDialog();
        }

       

        private void turmaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CADASTRARTURMA cadastroturma = new CADASTRARTURMA(bdConn);
            cadastroturma.ShowDialog();
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

        private void CADASTRARPROFESSOR_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
