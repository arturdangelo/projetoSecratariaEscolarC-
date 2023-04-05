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
using Microsoft.Reporting.WebForms;
using System.IO;
using System.Diagnostics;

namespace secraorg
{
    public partial class DECLARATRANSFERE : Form
    {
        private MySqlConnection bdConn;
        private Form principal;
       
        public DECLARATRANSFERE(MySqlConnection conex)
        {
            bdConn = conex;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            usuárioToolStripMenuItem.Enabled = false;
            turmaToolStripMenuItem.Enabled = false;
            professorToolStripMenuItem.Enabled = false;
            
            háVagasToolStripMenuItem.Enabled = false;
            prontuárioToolStripMenuItem.Enabled = false;
            prontuárioToolStripMenuItem1.Enabled = false;
            configuraçõesToolStripMenuItem.Enabled = false;

        }

        public DECLARATRANSFERE(MySqlConnection conex, String rm, Form tela)
        {
            bdConn = conex;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            principal = tela;
            

            usuárioToolStripMenuItem.Enabled = false;
            turmaToolStripMenuItem.Enabled = false;
            professorToolStripMenuItem.Enabled = false;
            
            háVagasToolStripMenuItem.Enabled = false;
            prontuárioToolStripMenuItem.Enabled = false;
            prontuárioToolStripMenuItem1.Enabled = false;
            configuraçõesToolStripMenuItem.Enabled = false;
            
            txtnascimento.Enabled = false;
            txtra.Enabled = false;
            txtnome.Enabled = false;
            

            var sqlcode = new MySqlCommand("Select * from aluno where  rm = " + rm, bdConn); //O comando usado do banco
            MySqlDataReader pesq = sqlcode.ExecuteReader(); //executa o comando acima
            while (pesq.Read())
            //(pesq["rm"].ToString()
            {
                txtra.Text = pesq["ra"].ToString();
                txtnome.Text = pesq["nome"].ToString();
                txtnascimento.Text = pesq["data_nascimento"].ToString();
             
            }

            pesq.Close();

        }
        private void declaraçãoSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DECLARACAOSIMPLES declaracaosimples = new DECLARACAOSIMPLES(bdConn);
            declaracaosimples.Show();
            
        }

        private void háVagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            CADASTRARALUNO cadastroaluno = new CADASTRARALUNO(bdConn);
            cadastroaluno.Show();
        }

        private void turmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void turmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            PESQUISARALUNO pesquisaaluno = new PESQUISARALUNO();
            pesquisaaluno.Show();
        }

        private void DECLARATRANSFERE_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bttpesquisar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            PESQUISASTRANSFERENCIA pesquisatransferencia = new PESQUISASTRANSFERENCIA(bdConn);
            pesquisatransferencia.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            

            //Caminho para encontrar o relatório
            reportViewer.LocalReport.ReportEmbeddedResource = "secraorg.relatoriotransferencia.rdlc";

            List<ReportParameter> listReportParameter = new List<ReportParameter>();
            listReportParameter.Add(new ReportParameter("Nome", txtnome.Text));
            listReportParameter.Add(new ReportParameter("RA", txtra.Text));
            listReportParameter.Add(new ReportParameter("Nasc", txtnascimento.Text));
            listReportParameter.Add(new ReportParameter("Tipo", txttipo.Text));
            listReportParameter.Add(new ReportParameter("Motivo", txtmotivo.Text));
            listReportParameter.Add(new ReportParameter("Obs", txtobs.Text));
            listReportParameter.Add(new ReportParameter("Data", "Ubatuba, " + DateTime.Now.ToString("dd 'd'e MMMM 'd'e yyyy.")));

            



            reportViewer.LocalReport.SetParameters(listReportParameter);

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;

            byte[] bytePDF = reportViewer.LocalReport.Render("pdf", null, out mimeType, out encoding,
                                out extension, out streamids, out warnings);

            FileStream fileStreamPDF = null;
            string relatorioPDF = Path.GetTempPath() + "Relatorio" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") +
                                                            ".pdf";

            fileStreamPDF = new FileStream(relatorioPDF, FileMode.Create);
            fileStreamPDF.Write(bytePDF, 0, bytePDF.Length);
            fileStreamPDF.Close();
            Process.Start(relatorioPDF); 
        }

        private void DECLARATRANSFERE_Load(object sender, EventArgs e)
        {
            txtnascimento.Enabled = false;
            txtnome.Enabled = false;
            txtra.Enabled = false;
        }

        private void txtobs_TextChanged(object sender, EventArgs e)
        {
            txtobs.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
