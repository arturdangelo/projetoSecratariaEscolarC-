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
    public partial class DECLARACAOSIMPLES : Form
    {
        private MySqlConnection bdConn;
        private Form principal;

               
        public DECLARACAOSIMPLES(MySqlConnection conex)
        {
            bdConn = conex;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            

            usuárioToolStripMenuItem.Enabled = false;
            turmaToolStripMenuItem.Enabled = false;
            professorToolStripMenuItem.Enabled = false;
            tansferenciaToolStripMenuItem.Enabled = true;
            háVagasToolStripMenuItem.Enabled = false;
            prontuárioToolStripMenuItem.Enabled = false;
            prontuárioToolStripMenuItem1.Enabled = false;
            configuraçõesToolStripMenuItem.Enabled = false;

            txtserie.Enabled = false;
            txtra.Enabled = false;
            txtnome.Enabled = false;
            txtano.Enabled = false;
            txtgrau.Enabled = false;
        }


        public DECLARACAOSIMPLES(MySqlConnection conex, String rm, Form tela)
        {
            bdConn = conex;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            principal = tela;
            

            usuárioToolStripMenuItem.Enabled = false;
            turmaToolStripMenuItem.Enabled = false;
            professorToolStripMenuItem.Enabled = false;
            tansferenciaToolStripMenuItem.Enabled = true;
            háVagasToolStripMenuItem.Enabled = false;
            prontuárioToolStripMenuItem.Enabled = false;
            prontuárioToolStripMenuItem1.Enabled = false;
            configuraçõesToolStripMenuItem.Enabled = false;

            txtserie.Enabled = false;
            txtra.Enabled = false;
            txtnome.Enabled = false;
            txtano.Enabled = false;
            txtgrau.Enabled = false;

            var sqlcode = new MySqlCommand("Select * from aluno where  rm = " + rm, bdConn); //O comando usado do banco
            MySqlDataReader pesq = sqlcode.ExecuteReader(); //executa o comando acima
            while (pesq.Read())
            //(pesq["rm"].ToString()
            {
                txtra.Text = pesq["ra"].ToString();
                txtnome.Text = pesq["nome"].ToString();
                txtserie.Text = pesq["serieS"].ToString();
                txtano.Text = pesq["ano"].ToString();
                txtgrau.Text = pesq["graug"].ToString();
            }

            pesq.Close();

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CADASTRARUSUARIO cadastrousuario = new CADASTRARUSUARIO(bdConn);
            cadastrousuario.ShowDialog();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            CADASTRARALUNO cadastroaluno = new CADASTRARALUNO(bdConn);
            cadastroaluno.Show();
        }

        private void turmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
             this.Dispose();
            CADASTRARTURMA cadastraturma = new CADASTRARTURMA(bdConn);
            cadastraturma.Show();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CADASTRARPROFESSOR cadastroprofessor = new CADASTRARPROFESSOR(bdConn);
            cadastroprofessor.ShowDialog();
        }

        private void turmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            PESQUISARALUNO pesquisaaluno = new PESQUISARALUNO();
            pesquisaaluno.Show();

        }


        private void passeProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DECLARATRANSFERE declaratransfere = new DECLARATRANSFERE(bdConn);
            declaratransfere.Show();
        }

        private void háVagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DECLARAVAGAS declaravagas = new DECLARAVAGAS(bdConn);
            declaravagas.Show();
        }

        private void DECLARACAOSIMPLES_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void DECLARACAOSIMPLES_Load(object sender, EventArgs e)
        {
            
        }

        private void bttpesquisar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            PESQUISARDECLARACAOSIMPLES pesquisadeclaraosimples = new PESQUISARDECLARACAOSIMPLES(bdConn);
            pesquisadeclaraosimples.Show();
        }

        private void bttimprimir_Click(object sender, EventArgs e)
        {
            String tipo = txttipo.Text;
            String grau = txtgrau.Text;
           

            if (grau == "1º") 
            {
                grau = "Ensino Fundamental";
            }

            else if (grau == "2º") 
            {
                grau = "Ensino Médio";
            }

            if(tipo =="Cadastro Passe"){
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;

            //Caminho para encontrar o relatório
            reportViewer.LocalReport.ReportEmbeddedResource = "secraorg.declaracaosimplescadastropasse.rdlc";

           


            List<ReportParameter> listReportParameter = new List<ReportParameter>();
            listReportParameter.Add(new ReportParameter("Nome", txtnome.Text));
            listReportParameter.Add(new ReportParameter("RA", txtra.Text));
            listReportParameter.Add(new ReportParameter("Ano", txtano.Text));
            listReportParameter.Add(new ReportParameter("Obs", txtobs.Text));
            listReportParameter.Add(new ReportParameter("Serie", txtserie.Text));
            listReportParameter.Add(new ReportParameter("Grau", grau));
            listReportParameter.Add(new ReportParameter("Freq", txtfreq.Text));
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
            else if (tipo == "Bolsa Família") 
            {
                ReportViewer reportViewer = new ReportViewer();
                reportViewer.ProcessingMode = ProcessingMode.Local;

                //Caminho para encontrar o relatório
                reportViewer.LocalReport.ReportEmbeddedResource = "secraorg.declaracaosimplesbolsafamilia.rdlc";


                List<ReportParameter> listReportParameter = new List<ReportParameter>();
                listReportParameter.Add(new ReportParameter("Nome", txtnome.Text));
                listReportParameter.Add(new ReportParameter("RA", txtra.Text));
                listReportParameter.Add(new ReportParameter("Ano", txtano.Text));
                listReportParameter.Add(new ReportParameter("Obs", txtobs.Text));
                listReportParameter.Add(new ReportParameter("Serie", txtserie.Text));
                listReportParameter.Add(new ReportParameter("Grau", grau));
                listReportParameter.Add(new ReportParameter("Data","Ubatuba, " + DateTime.Now.ToString("dd 'd'e MMMM 'd'e yyyy.")));


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
            
        }

        private void txtobs_TextChanged(object sender, EventArgs e)
        {
            txtobs.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
