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
    public partial class EXIBIRALUNO : Form
    {
        private MySqlConnection bdConn;
        

        public EXIBIRALUNO(MySqlConnection conex)
        {
            bdConn = conex;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        public EXIBIRALUNO(MySqlConnection conex, String rm)
        {
            bdConn = conex;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            var sqlcode = new MySqlCommand("Select * from aluno where  rm = " + rm, bdConn); //O comando usado do banco
            MySqlDataReader pesq = sqlcode.ExecuteReader(); //executa o comando acima
            while (pesq.Read())
            //(pesq["rm"].ToString()
            {
                txtrm.Text = pesq["rm"].ToString();
                txtra.Text = pesq["ra"].ToString();
                txtnomealuno.Text = pesq["nome"].ToString();
                txtcidade.Text = pesq["cidade_nascimento"].ToString();
                txtestado.Text = pesq["estado"].ToString();
                txtnacionalidade.Text = pesq["nacionalidade"].ToString();
                txtnascimento.Text = pesq["data_nascimento"].ToString();
                txtsexo.Text = pesq["sexo"].ToString();
                txtrg.Text = pesq["rg"].ToString();
                maskedTextBox1.Text = pesq["cpf"].ToString();
                txtmae.Text = pesq["nome_mae"].ToString();
                txtpai.Text = pesq["nome_pai"].ToString();
                txtlogradouro.Text = pesq["logradouro"].ToString();
                txtnumerolog.Text = pesq["num_logradouro"].ToString();
                txtcomplemento.Text = pesq["complemento"].ToString();
                txtbairro.Text = pesq["bairro"].ToString();
                txtfixo.Text = pesq["telefone_fixo"].ToString();
                txtcel1.Text = pesq["celular1"].ToString();
                txtcel2.Text = pesq["celular2"].ToString();
                txtobs.Text = pesq["observacao"].ToString();
                txtescolaanterior.Text = pesq["escola_anterior"].ToString();
                txtserieant.Text = pesq["serie_ant"].ToString();
                txtgrauant.Text = pesq["grau_anterior"].ToString();
                txtcidadeant.Text = pesq["cidade_anterior"].ToString();
                txtestadoant.Text = pesq["estado_anterior"].ToString();
                txtseriepret.Text = pesq["serie_pretendida"].ToString();
                txtgraupret.Text = pesq["grau_pretendido"].ToString();
                txtestudou.Text = pesq["estudou_aqui"].ToString();
                txtano.Text = pesq["ano"].ToString();
                txtTurno.Text = pesq["turnoT"].ToString();
                txtgrau.Text = pesq["graug"].ToString();
                txtserie.Text = pesq["serieS"].ToString();
                txtturma.Text = pesq["turmat"].ToString();
                txtnumero.Text = pesq["numeroN"].ToString();


            }

        }

        public bool Valida(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(",", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }                


        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void turmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PESQUISARALUNO pesquisaaluno = new PESQUISARALUNO();
            pesquisaaluno.ShowDialog();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            txtusu.Enabled = false;
            txtrm.Enabled = false;
            txtra.Enabled = false;
            txtnomealuno.Enabled = false;
            txtcidade.Enabled = false;
            txtestado.Enabled = false;
            txtnacionalidade.Enabled = false;
            txtnascimento.Enabled = false;
            txtsexo.Enabled = false;
            txtrg.Enabled = false;
            maskedTextBox1.Enabled = false;
            txtmae.Enabled = false;
            txtpai.Enabled = false;
            txtlogradouro.Enabled = false;
            txtnumerolog.Enabled = false;
            txtcomplemento.Enabled = false;
            txtbairro.Enabled = false;
            txtfixo.Enabled = false;
            txtcel1.Enabled = false;
            txtcel2.Enabled = false;
            txtobs.Enabled = false;
            txtescolaanterior.Enabled = false;
            txtserieant.Enabled = false;
            txtgrauant.Enabled = false;
            txtcidadeant.Enabled = false;
            txtestadoant.Enabled = false;
            txtseriepret.Enabled = false;
            txtgraupret.Enabled = false;
            txtestudou.Enabled = false;
            txtano.Enabled = false;
            txtTurno.Enabled = false;
            txtgrau.Enabled = false;
            txtserie.Enabled = false;
            txtturma.Enabled = false;
            txtnumero.Enabled = false;

            usuárioToolStripMenuItem.Enabled = false;
            turmaToolStripMenuItem.Enabled = false;
            professorToolStripMenuItem.Enabled = false;
            declaraçãoSimplesToolStripMenuItem.Enabled = false;
            passeProfessorToolStripMenuItem.Enabled = false;
            háVagasToolStripMenuItem.Enabled = false;
            prontuárioToolStripMenuItem.Enabled = false;
            prontuárioToolStripMenuItem1.Enabled = false;
            configuraçõesToolStripMenuItem.Enabled = false;
            bttSalvarAlt.Enabled = false;
            bttLimpar.Enabled = false;
            bttSalvar.Enabled = false;
        }

        private void EXIBIRALUNO_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bttSalvar_Click(object sender, EventArgs e)
        {
             String temp = maskedTextBox1.Text.Replace(",", "").Replace("-", "").Replace(".", "");
                Valida(temp);
                String temprm = txtrm.Text;

                if ((temprm.Length) < 8)
                {
                    MessageBox.Show("Campo RM está vazio ou incompleto");
                }

                String tempra = txtra.Text;
                if ((tempra.Length) < 13)
                {
                    MessageBox.Show("Campo RA está vazio ou incompleto");
                }

                String tempnomealuno = txtnomealuno.Text;
                if ((tempnomealuno.Length) == 0)
                {
                    MessageBox.Show("Campo nome está vazio");
                }

                String tempcidade = txtcidade.Text;
                if ((tempcidade.Length) == 0)
                {
                    MessageBox.Show("Campo CIDADE está vazio");
                }

                String tempestado = txtestado.Text;
                if ((tempestado.Length) == 0)
                {
                    MessageBox.Show("Campo ESTADO de origem não selecionado");
                }

                String tempnacionalidade = txtnacionalidade.Text;
                if ((tempnacionalidade.Length) == 0)
                {
                    MessageBox.Show("Campo NACIONALIDADE está vazio");
                }


                String tempnascimento = txtnascimento.Text;
                if ((tempnascimento.Length) < 10)
                {
                    MessageBox.Show("Campo NASCIMENTO vazio ou incompleto");
                }

                String tempsexo = txtsexo.Text;
                if ((tempsexo.Length) == 0)
                {
                    MessageBox.Show("Campo SEXO não selecionado");
                }

                String tempmae = txtmae.Text;
                if ((tempmae.Length) == 0)
                {
                    MessageBox.Show("Campo MÃE vazio");
                }

                String templogradouro = txtlogradouro.Text;
                if ((templogradouro.Length) == 0)
                {
                    MessageBox.Show("Campo LOGRADOURO vazio");
                }

                String tempnumerolog = txtnumerolog.Text;
                if ((tempnumerolog.Length) == 0)
                {
                    MessageBox.Show("Campo NÚMERO do logradouro vazio, caso não existir, coloque o número 0");
                }

                String tempbairro = txtbairro.Text;
                if ((tempbairro.Length) == 0)
                {
                    MessageBox.Show("Campo BAIRRO vazio");
                }

                String tempcel1 = txtcel1.Text;
                if ((tempcel1.Length) < 14)
                {
                    MessageBox.Show("Primeiro campo CELULAR incompleto ou vazio");
                }

                String tempseriepret = txtseriepret.Text;
                if ((tempseriepret.Length) == 0)
                {
                    MessageBox.Show("Campo SÉRIE PRETENDIDA não selecionado");
                }

                String tempgraupret = txtgraupret.Text;
                if ((tempgraupret.Length) == 0)
                {
                    MessageBox.Show("Campo GRAU PRETENDIDO não selecionado");
                }

                String tempestudou = txtestudou.Text;
                if ((tempestudou.Length) == 0)
                {
                    MessageBox.Show("Campo ESTUDOU AQUI não selecionado");
                }

                String tempano = txtano.Text;
                if ((tempano.Length) < 4)
                {
                    MessageBox.Show("Campo ANO incompleto ou vazio");
                }

                String tempTurno = txtTurno.Text;
                if ((tempTurno.Length) == 0)
                {
                    MessageBox.Show("Campo TURNO não selecionado");
                }

                String tempgrau = txtgrau.Text;
                if ((tempgrau.Length) == 0)
                {
                    MessageBox.Show("Campo GRAU não selecionado");
                }

                String tempserie = txtserie.Text;
                if ((tempserie.Length) == 0)
                {
                    MessageBox.Show("Campo SÉRIE não selecionado");
                }

                String tempturma = txtturma.Text;
                if ((tempturma.Length) == 0)
                {
                    MessageBox.Show("Campo TURMA não selecionado");
                }

                //MessageBox.Show("" + temp.Trim().Length );
                
                if ((temp.Trim().Length==11 && Valida(temp)==false) || temp.Trim().Length>0 && temp.Trim().Length<11)
                {                   
                    
                    {
                        MessageBox.Show("CPF inválido");
                    }
                }
         


                //se estiver completo, entra um if else, no if verifica se é verdadeiro

                else if ((temprm.Length) >= 8 && (tempra.Length) >= 13 && (tempnomealuno.Length) != 0 && (tempcidade.Length) != 0 && (tempestado.Length) != 0 
                    && (tempsexo.Length) != 0 && (tempmae.Length) != 0 && (templogradouro.Length) != 0 && (tempnumerolog.Length) != 0 
                    && (tempbairro.Length) != 0 && (tempcel1.Length) >= 14 && (tempseriepret.Length) >= 0 && (tempgraupret.Length) != 0
                    && (tempestudou.Length) != 0 && (tempano.Length) >= 4 && (tempTurno.Length) != 0 && (tempgrau.Length) != 0
                    && (tempserie.Length) != 0 && (tempturma.Length) != 0) 
            {
                
                //Verifica se a conexão está aberta
                if (bdConn.State == ConnectionState.Open)
                {

                    String rm = txtrm.Text;
                    String ra = txtra.Text;
                    String nomealuno = txtnomealuno.Text;
                    String cidadenascimento = txtcidade.Text;
                    String estadonascimento = txtestado.Text;
                    String nacionalidade = txtnacionalidade.Text;
                    String nascimento = txtnascimento.Text;
                    String sexo = txtsexo.Text;
                    String rg = txtrg.Text;
                    String cpf = maskedTextBox1.Text;
                    String nomemae = txtmae.Text;
                    String nomepai = txtpai.Text;
                    String logradouro = txtlogradouro.Text;
                    String numerolog = txtnumerolog.Text;
                    String complemento = txtcomplemento.Text;
                    String bairro = txtbairro.Text;
                    String telefonefixo = txtfixo.Text;
                    String celular1 = txtcel1.Text;
                    String celular2 = txtcel2.Text;
                    String observacao = txtobs.Text;
                    String escolaanterior = txtescolaanterior.Text;
                    String serieanterior = txtserieant.Text;
                    String grauanterior = txtgrauant.Text;
                    String cidadeanterior = txtcidadeant.Text;
                    String estadoanterior = txtestadoant.Text;
                    String seriepretendida = txtseriepret.Text;
                    String graupretendido = txtgraupret.Text;
                    String estudou_aqui = txtestudou.Text;
                    String ano = txtano.Text;
                    String turno = txtTurno.Text;
                    String grau = txtgrau.Text;
                    String serie = txtserie.Text;
                    String turma = txtturma.Text;
                    String numero = txtnumero.Text;

                    //Se estiver aberta insere os dados na BD
                    String sql = "INSERT INTO aluno(rm,ra,nome,cidade_nascimento,nacionalidade,"
                                    + "estado,data_nascimento,sexo,rg,cpf,nome_mae,nome_pai,logradouro,"
                                    + "num_logradouro,complemento,bairro,telefone_fixo,celular1,"
                                    + "celular2,observacao,escola_anterior,serie_ant,grau_anterior,"
                                    + "cidade_anterior,estado_anterior,serie_pretendida,grau_pretendido,"
                                    + "estudou_aqui,ano,turnoT,graug,serieS,turmat,numeroN)"
                       + "VALUES('" + rm + "','" + ra + "','" + nomealuno + "','" + cidadenascimento + "','"
                       + nacionalidade + "','" + estadonascimento + "','" + nascimento + "','" + sexo + "','"
                       + rg + "','" + cpf + "','" + nomemae + "','" + nomepai + "','"
                       + logradouro + "','" + numerolog + "','" + complemento + "','" + bairro + "','"
                       + telefonefixo + "','" + celular1 + "','" + celular2 + "','"
                       + observacao + "','" + escolaanterior + "','" + serieanterior + "','" + grauanterior + "','"
                       + cidadeanterior + "','" + estadoanterior + "','"
                       + seriepretendida + "','" + graupretendido + "','" + estudou_aqui + "','" + ano + "','"
                       + turno + "','" + grau + "','"
                       + serie + "','" + turma + "','" + numero + "');";

                    MessageBox.Show("Cadastro completo");
                   
                   
                    MySqlCommand commS = new MySqlCommand(sql, bdConn);
                    commS.BeginExecuteNonQuery();

                    txtrm.Enabled = false;
                    txtra.Enabled = false;
                    txtnomealuno.Enabled = false;
                    txtcidade.Enabled = false;
                    txtestado.Enabled = false;
                    txtnacionalidade.Enabled = false;
                    txtnascimento.Enabled = false;
                    txtsexo.Enabled = false;
                    txtrg.Enabled = false;
                    maskedTextBox1.Enabled = false;
                    txtmae.Enabled = false;
                    txtpai.Enabled = false;
                    txtlogradouro.Enabled = false;
                    txtnumerolog.Enabled = false;
                    txtcomplemento.Enabled = false;
                    txtbairro.Enabled = false;
                    txtfixo.Enabled = false;
                    txtcel1.Enabled = false;
                    txtcel2.Enabled = false;
                    txtobs.Enabled = false;
                    txtescolaanterior.Enabled = false;
                    txtserieant.Enabled = false;
                    txtgrauant.Enabled = false;
                    txtcidadeant.Enabled = false;
                    txtestadoant.Enabled = false;
                    txtseriepret.Enabled = false;
                    txtgraupret.Enabled = false;
                    txtestudou.Enabled = false;
                    txtano.Enabled = false;
                    txtTurno.Enabled = false;
                    txtgrau.Enabled = false;
                    txtserie.Enabled = false;
                    txtturma.Enabled = false;
                    txtnumero.Enabled = false;

                    bttAlterar.Enabled = true;
                    bttImprimir.Enabled = true;
                    bttLimpar.Enabled = false;
                    bttSalvar.Enabled = false;
                    

                    
                    
                  

                }

            }

                   
                
        }

        private void bttAlterar_Click(object sender, EventArgs e)
        {
            //txtrm.Enabled = true;
            txtra.Enabled = true;
            txtnomealuno.Enabled = true;
            txtcidade.Enabled = true;
            txtestado.Enabled = true;
            txtnacionalidade.Enabled = true;
            txtnascimento.Enabled = true;
            txtsexo.Enabled = true;
            txtrg.Enabled = true;
            maskedTextBox1.Enabled = true;
            txtmae.Enabled = true;
            txtpai.Enabled = true;
            txtlogradouro.Enabled = true;
            txtnumerolog.Enabled = true;
            txtcomplemento.Enabled = true;
            txtbairro.Enabled = true;
            txtfixo.Enabled = true;
            txtcel1.Enabled = true;
            txtcel2.Enabled = true;
            txtobs.Enabled = true;
            txtescolaanterior.Enabled = true;
            txtserieant.Enabled = true;
            txtgrauant.Enabled = true;
            txtcidadeant.Enabled = true;
            txtestadoant.Enabled = true;
            txtseriepret.Enabled = true;
            txtgraupret.Enabled = true;
            txtestudou.Enabled = true;
            txtano.Enabled = true;
            txtTurno.Enabled = true;
            txtgrau.Enabled = true;
            txtserie.Enabled = true;
            txtturma.Enabled = true;
            txtnumero.Enabled = true;

            bttSalvarAlt.Enabled = true;
            bttLimpar.Enabled = true;
            bttImprimir.Enabled = false;
        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            txtrm.Text = (" ");
            txtra.Text = (" ");
            txtnomealuno.Text = (" ");
            txtcidade.Text = (" ");
            txtestado.Text = null;
            txtnacionalidade.Text = (" ");
            txtnascimento.Text = (" ");
            txtsexo.Text = null;
            txtrg.Text = (" ");
            maskedTextBox1.Text = (" ");
            txtmae.Text = (" ");
            txtpai.Text = (" ");
            txtlogradouro.Text = (" ");
            txtnumerolog.Text = (" ");
            txtcomplemento.Text = (" ");
            txtbairro.Text = (" ");
            txtfixo.Text = (" ");
            txtcel1.Text = (" ");
            txtcel2.Text = (" ");
            txtobs.Text = (" ");
            txtescolaanterior.Text = (" ");
            txtserieant.Text = null;
            txtgrauant.Text = null;
            txtcidadeant.Text = (" ");
            txtestadoant.Text = null;
            txtseriepret.Text = null;
            txtgraupret.Text = null;
            txtestudou.Text = null;
            txtano.Text = (" ");
            txtTurno.Text = null;
            txtgrau.Text = null;
            txtserie.Text = null;
            txtturma.Text = null;
            txtnumero.Text = null;

            bttSalvarAlt.Enabled = true;
            bttImprimir.Enabled = false;
            bttAlterar.Enabled = false;
            bttSalvar.Enabled = true;
            txtrm.Enabled = true;
        }

        private void bttSalvarAlt_Click(object sender, EventArgs e)
        {
            String temp = maskedTextBox1.Text.Replace(",", "").Replace("-", "").Replace(".", "");
            Valida(temp);
            String temprm = txtrm.Text;



            String tempra = txtra.Text;
            if ((tempra.Length) < 13)
            {
                MessageBox.Show("Campo RA está vazio ou incompleto");
            }

            String tempnomealuno = txtnomealuno.Text;
            if ((tempnomealuno.Length) == 0)
            {
                MessageBox.Show("Campo nome está vazio");
            }

            String tempcidade = txtcidade.Text;
            if ((tempcidade.Length) == 0)
            {
                MessageBox.Show("Campo CIDADE está vazio");
            }

            String tempestado = txtestado.Text;
            if ((tempestado.Length) == 0)
            {
                MessageBox.Show("Campo ESTADO de origem não selecionado");
            }

            String tempnacionalidade = txtnacionalidade.Text;
            if ((tempnacionalidade.Length) == 0)
            {
                MessageBox.Show("Campo NACIONALIDADE está vazio");
            }


            String tempnascimento = txtnascimento.Text;
            if ((tempnascimento.Length) < 10)
            {
                MessageBox.Show("Campo NASCIMENTO vazio ou incompleto");
            }

            String tempsexo = txtsexo.Text;
            if ((tempsexo.Length) == 0)
            {
                MessageBox.Show("Campo SEXO não selecionado");
            }

            String tempmae = txtmae.Text;
            if ((tempmae.Length) == 0)
            {
                MessageBox.Show("Campo MÃE vazio");
            }

            String templogradouro = txtlogradouro.Text;
            if ((templogradouro.Length) == 0)
            {
                MessageBox.Show("Campo LOGRADOURO vazio");
            }

            String tempnumerolog = txtnumerolog.Text;
            if ((tempnumerolog.Length) == 0)
            {
                MessageBox.Show("Campo NÚMERO do logradouro vazio, caso não existir, coloque o número 0");
            }

            String tempbairro = txtbairro.Text;
            if ((tempbairro.Length) == 0)
            {
                MessageBox.Show("Campo BAIRRO vazio");
            }

            String tempcel1 = txtcel1.Text;
            if ((tempcel1.Length) < 14)
            {
                MessageBox.Show("Primeiro campo CELULAR incompleto ou vazio");
            }

            String tempseriepret = txtseriepret.Text;
            if ((tempseriepret.Length) == 0)
            {
                MessageBox.Show("Campo SÉRIE PRETENDIDA não selecionado");
            }

            String tempgraupret = txtgraupret.Text;
            if ((tempgraupret.Length) == 0)
            {
                MessageBox.Show("Campo GRAU PRETENDIDO não selecionado");
            }

            String tempestudou = txtestudou.Text;
            if ((tempestudou.Length) == 0)
            {
                MessageBox.Show("Campo ESTUDOU AQUI não selecionado");
            }

            String tempano = txtano.Text;
            if ((tempano.Length) < 4)
            {
                MessageBox.Show("Campo ANO incompleto ou vazio");
            }

            String tempTurno = txtTurno.Text;
            if ((tempTurno.Length) == 0)
            {
                MessageBox.Show("Campo TURNO não selecionado");
            }

            String tempgrau = txtgrau.Text;
            if ((tempgrau.Length) == 0)
            {
                MessageBox.Show("Campo GRAU não selecionado");
            }

            String tempserie = txtserie.Text;
            if ((tempserie.Length) == 0)
            {
                MessageBox.Show("Campo SÉRIE não selecionado");
            }

            String tempturma = txtturma.Text;
            if ((tempturma.Length) == 0)
            {
                MessageBox.Show("Campo TURMA não selecionado");
            }

          

            if ((temp.Trim().Length == 11 && Valida(temp) == false) || temp.Trim().Length > 0 && temp.Trim().Length < 11)
            {

                {
                    MessageBox.Show("CPF inválido");
                }
            }
           

            else if ((temprm.Length) >= 8 && (tempra.Length) >= 13 && (tempnomealuno.Length) != 0 && (tempcidade.Length) != 0 && (tempestado.Length) != 0
                && (tempsexo.Length) != 0 && (tempmae.Length) != 0 && (templogradouro.Length) != 0 && (tempnumerolog.Length) != 0
                && (tempbairro.Length) != 0 && (tempcel1.Length) >= 14 && (tempseriepret.Length) >= 0 && (tempgraupret.Length) != 0
                && (tempestudou.Length) != 0 && (tempano.Length) >= 4 && (tempTurno.Length) != 0 && (tempgrau.Length) != 0
                && (tempserie.Length) != 0 && (tempturma.Length) != 0)
            {
                /*Valida(temp);
                if (Valida(temp) == true)
                {*/
                //Verifica se a conexão está aberta
                if (bdConn.State == ConnectionState.Open)
                {
                    String rm = txtrm.Text;
                    String ra = txtra.Text;
                    String nomealuno = txtnomealuno.Text;
                    String cidadenascimento = txtcidade.Text;
                    String estadonascimento = txtestado.Text;
                    String nacionalidade = txtnacionalidade.Text;
                    String nascimento = txtnascimento.Text;
                    String sexo = txtsexo.Text;
                    String rg = txtrg.Text;
                    String cpf = maskedTextBox1.Text;
                    String nomemae = txtmae.Text;
                    String nomepai = txtpai.Text;
                    String logradouro = txtlogradouro.Text;
                    String numerolog = txtnumerolog.Text;
                    String complemento = txtcomplemento.Text;
                    String bairro = txtbairro.Text;
                    String telefonefixo = txtfixo.Text;
                    String celular1 = txtcel1.Text;
                    String celular2 = txtcel2.Text;
                    String observacao = txtobs.Text;
                    String escolaanterior = txtescolaanterior.Text;
                    String serieanterior = txtserieant.Text;
                    String grauanterior = txtgrauant.Text;
                    String cidadeanterior = txtcidadeant.Text;
                    String estadoanterior = txtestadoant.Text;
                    String seriepretendida = txtseriepret.Text;
                    String graupretendido = txtgraupret.Text;
                    String estudou_aqui = txtestudou.Text;
                    String ano = txtano.Text;
                    String turno = txtTurno.Text;
                    String grau = txtgrau.Text;
                    String serie = txtserie.Text;
                    String turma = txtturma.Text;
                    String numero = txtnumero.Text;

                    //Se estiver aberta insere os dados na BD
                    //String sql = "UPDATE aluno SET nome='ARTUR' where rm='1111111111';";
                        String sql = "UPDATE aluno SET ra='"+ra+"',nome='"+nomealuno+"',cidade_nascimento='"+cidadenascimento+"',"
                                    + "nacionalidade='"+nacionalidade+"',estado='"+estadonascimento+"',"
                                    +"data_nascimento='"+nascimento+"',sexo='"+sexo+"',rg='"+rg+"',cpf='"+cpf+"',"
                                    +"nome_mae='"+nomemae+"',nome_pai='"+nomepai+"',logradouro='"+logradouro+"',"
                                    + "num_logradouro='"+numerolog+"',complemento='"+complemento+"',"
                                    +"bairro='"+bairro+"',telefone_fixo='"+telefonefixo+"',celular1='"+celular1+"',"
                                    + "celular2='"+celular2+"',observacao='"+observacao+"',"
                                    +"escola_anterior='"+escolaanterior+"',serie_ant='"+serieanterior+"',"
                                    +"grau_anterior='"+grauanterior+"',cidade_anterior='"+cidadeanterior+"',"
                                    +"estado_anterior='"+estadoanterior+"',serie_pretendida='"+seriepretendida+"',"
                                    +"grau_pretendido='"+graupretendido+"',estudou_aqui='"+estudou_aqui+"',"
                                    +"ano='"+ano+"',turnoT='"+turno+"',graug='"+grau+"',serieS='"+serie+"',"
                                    + "turmat='" + turma + "',numeroN='" + numero + "'where rm='1111111111';";

                   


                    MySqlCommand commS1;
                    commS1 = new MySqlCommand(sql, bdConn);
                   // commS= new MySqlCommand(sql, bdConn);

                    commS1.BeginExecuteNonQuery();
                  // MessageBox.Show(""+commS.BeginExecuteNonQuery()+"");

                    txtrm.Enabled = false;
                    txtra.Enabled = false;
                    txtnomealuno.Enabled = false;
                    txtcidade.Enabled = false;
                    txtestado.Enabled = false;
                    txtnacionalidade.Enabled = false;
                    txtnascimento.Enabled = false;
                    txtsexo.Enabled = false;
                    txtrg.Enabled = false;
                    maskedTextBox1.Enabled = false;
                    txtmae.Enabled = false;
                    txtpai.Enabled = false;
                    txtlogradouro.Enabled = false;
                    txtnumerolog.Enabled = false;
                    txtcomplemento.Enabled = false;
                    txtbairro.Enabled = false;
                    txtfixo.Enabled = false;
                    txtcel1.Enabled = false;
                    txtcel2.Enabled = false;
                    txtobs.Enabled = false;
                    txtescolaanterior.Enabled = false;
                    txtserieant.Enabled = false;
                    txtgrauant.Enabled = false;
                    txtcidadeant.Enabled = false;
                    txtestadoant.Enabled = false;
                    txtseriepret.Enabled = false;
                    txtgraupret.Enabled = false;
                    txtestudou.Enabled = false;
                    txtano.Enabled = false;
                    txtTurno.Enabled = false;
                    txtgrau.Enabled = false;
                    txtserie.Enabled = false;
                    txtturma.Enabled = false;
                    txtnumero.Enabled = false;

                    bttAlterar.Enabled = true;
                    bttImprimir.Enabled = true;
                    bttLimpar.Enabled = false;
                    bttSalvar.Enabled = false;

               }
            }
        }

        private void txtnomealuno_TextChanged(object sender, EventArgs e)
        {
            txtnomealuno.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
