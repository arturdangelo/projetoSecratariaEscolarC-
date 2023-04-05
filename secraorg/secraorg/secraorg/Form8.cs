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
    public partial class DECLARAVAGAS : Form
    {
        private MySqlConnection bdConn;
        
        public DECLARAVAGAS(MySqlConnection conex)
        {
            bdConn = conex;
            InitializeComponent();
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

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CADASTRARUSUARIO cadastrousuario = new CADASTRARUSUARIO(bdConn);
            cadastrousuario.ShowDialog();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CADASTRARALUNO cadastroaluno = new CADASTRARALUNO(bdConn, this);
            cadastroaluno.ShowDialog();
        }

        private void turmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CADASTRARTURMA cadastroturma = new CADASTRARTURMA(bdConn);
            cadastroturma.ShowDialog();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void DECLARAVAGAS_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    }
}
