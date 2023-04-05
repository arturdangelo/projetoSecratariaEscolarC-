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
    public partial class CADASTRARALUNO : Form
    {
        private MySqlConnection bdConn;
        private Form principal;

        public CADASTRARALUNO(MySqlConnection conex) 
        {
            bdConn = conex;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            

            txtusu.Enabled = false;
            usuárioToolStripMenuItem.Enabled = false;
            turmaToolStripMenuItem.Enabled = false;
            professorToolStripMenuItem.Enabled = false;
            declaracaoSimplesToolStripMenuItem.Enabled = true;
            transferenciaToolStripMenuItem.Enabled = true;
            háVagasToolStripMenuItem.Enabled = false;
            prontuárioToolStripMenuItem.Enabled = false;
            prontuárioToolStripMenuItem1.Enabled = false;
            configuraçõesToolStripMenuItem.Enabled = false;
            bttAlterar.Enabled = false;
            bttSalvarAlt.Enabled = false;
            bttImprimir.Enabled = false;
            bttNovo.Enabled = false;
            bttAltCPF.Enabled = false;
            bttAltRA.Enabled = false;
            bttAltRM.Enabled = false;
        }
        public CADASTRARALUNO(MySqlConnection conex, Form tela)
        {
            bdConn = conex;    
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            principal = tela;

            txtusu.Enabled = false;
            usuárioToolStripMenuItem.Enabled = false;
            turmaToolStripMenuItem.Enabled = false;
            professorToolStripMenuItem.Enabled = false;
            declaracaoSimplesToolStripMenuItem.Enabled = true;
            transferenciaToolStripMenuItem.Enabled = true;
            háVagasToolStripMenuItem.Enabled = false;
            prontuárioToolStripMenuItem.Enabled = false;
            prontuárioToolStripMenuItem1.Enabled = false;
            configuraçõesToolStripMenuItem.Enabled = false;
            bttAlterar.Enabled = false;
            bttSalvarAlt.Enabled = false;
            bttImprimir.Enabled = false;
            bttNovo.Enabled = false;
            bttAltCPF.Enabled = false;
            bttAltRA.Enabled = false;
            bttAltRM.Enabled = false;
            
        }

        public CADASTRARALUNO(MySqlConnection conex, String rm, Form tela)
        {
            bdConn = conex;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            principal = tela;

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
                txtfixo.Text = pesq["telefone"].ToString();
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
                declaracaoSimplesToolStripMenuItem.Enabled = true;
                transferenciaToolStripMenuItem.Enabled = true;
                háVagasToolStripMenuItem.Enabled = false;
                prontuárioToolStripMenuItem.Enabled = false;
                prontuárioToolStripMenuItem1.Enabled = false;
                configuraçõesToolStripMenuItem.Enabled = false;
                bttAlterar.Enabled = true;
                bttSalvarAlt.Enabled = false;
                bttNovo.Enabled = true;
                bttSalvar.Enabled = false;
                bttImprimir.Enabled = true;

            }

            pesq.Close();

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

        private void professorToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void declaracaoSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void CADASTRARALUNO_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }       

        // validando cpf
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

        private void txtnomealuno_TextChanged_1(object sender, EventArgs e)
        {
            txtnomealuno.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtnomealuno_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar == 32) || (e.KeyChar == 08) || (e.KeyChar == 127)))
            {
                e.Handled = true;
            } 
        }

        private void txtcidade_TextChanged(object sender, EventArgs e)
        {
            txtcidade.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtcidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar == 32) || (e.KeyChar == 08) || (e.KeyChar == 127)))
            {
                e.Handled = true;
            }
        }

        private void txtnacionalidade_TextChanged(object sender, EventArgs e)
        {
            txtnacionalidade.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtnacionalidade_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar == 32) || (e.KeyChar == 08) || (e.KeyChar == 127)))
            {
                e.Handled = true;
            }
        }

        private void txtmae_TextChanged(object sender, EventArgs e)
        {
            txtmae.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtmae_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar == 32) || (e.KeyChar == 08) || (e.KeyChar == 127)))
            {
                e.Handled = true;
            }
        }

        private void txtpai_TextChanged(object sender, EventArgs e)
        {
            txtpai.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtpai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar == 32) || (e.KeyChar == 08) || (e.KeyChar == 127)))
            {
                e.Handled = true;
            }
        }

        private void txtlogradouro_TextChanged(object sender, EventArgs e)
        {
            txtlogradouro.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtlogradouro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar == 32) || (e.KeyChar == 08) || (e.KeyChar == 127)))
            {
                e.Handled = true;
            }
        }

        private void txtbairro_TextChanged(object sender, EventArgs e)
        {
            txtbairro.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtbairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar == 32) || (e.KeyChar == 08) || (e.KeyChar == 127)))
            {
                e.Handled = true;
            }
        }

        private void txtobs_TextChanged(object sender, EventArgs e)
        {
            txtobs.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtobs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar == 32) ||
                (e.KeyChar == 08) || (e.KeyChar == 127) || (e.KeyChar >='0' && (e.KeyChar <='9'))))
            {
                e.Handled = true;
            }
        }

        private void txtescolaanterior_TextChanged(object sender, EventArgs e)
        {
            txtescolaanterior.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtescolaanterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar == 32) || (e.KeyChar == 08) || (e.KeyChar == 127)))
            {
                e.Handled = true;
            }
        }

        private void txtcidadeant_TextChanged(object sender, EventArgs e)
        {
            txtcidadeant.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtcidadeant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar == 32) || (e.KeyChar == 08) || (e.KeyChar == 127)))
            {
                e.Handled = true;
            }


        }

        private void txtcomplemento_TextChanged(object sender, EventArgs e)
        {
            txtcomplemento.CharacterCasing = CharacterCasing.Upper;
            
        }

        private void txtcomplemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar == 32) ||
               (e.KeyChar == 08) || (e.KeyChar == 127) || (e.KeyChar >= '0' && (e.KeyChar <= '9'))))
            {
                e.Handled = true;
            }
        }

        private void txtrg_TextChanged(object sender, EventArgs e)
        {
            txtrg.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar == 32) ||
               (e.KeyChar == 08) || (e.KeyChar == 127) || (e.KeyChar >= '0' && (e.KeyChar <= '9'))))
            {
                e.Handled = true;
            }
        }

        //SALVAR/CADASTRAR
        private void button2_Click_1(object sender, EventArgs e)
        {
            String temp = maskedTextBox1.Text.Replace(",", "").Replace("-", "").Replace(".", "");
            Valida(temp);
            String temprm = txtrm.Text;
            String tempra = txtra.Text;
            String tempnomealuno = txtnomealuno.Text;
            String tempcidade = txtcidade.Text;
            String tempestado = txtestado.Text;
            String tempnacionalidade = txtnacionalidade.Text;
            String tempnascimento = txtnascimento.Text;
            String tempsexo = txtsexo.Text;
            String tempmae = txtmae.Text;
            String templogradouro = txtlogradouro.Text;
            String tempnumerolog = txtnumerolog.Text;
            String tempbairro = txtbairro.Text;
            String tempseriepret = txtseriepret.Text;
            String tempgraupret = txtgraupret.Text;
            String tempestudou = txtestudou.Text;
            String tempano = txtano.Text;
            String tempTurno = txtTurno.Text;
            String tempgrau = txtgrau.Text;
            String tempserie = txtserie.Text;
            String tempturma = txtturma.Text;




            if ((temprm.Length) < 4)
            {
                MessageBox.Show("Campo RM está vazio ou incompleto");

            }

            else
            {
                var sqlcode = new MySqlCommand("Select * from aluno where  rm = " + temprm + ";", bdConn); //O comando usado do banco
                MySqlDataReader pesq = sqlcode.ExecuteReader(); //executa o comando acima
                Boolean existe = pesq.Read();
                pesq.Close();
                if (existe)
                {
                    MessageBox.Show("RM já cadastrado");
                }


                else if ((tempra.Length) < 8)
                {
                    MessageBox.Show("Campo RM está vazio ou incompleto");
                }

                else
                {
                    sqlcode = new MySqlCommand("Select * from aluno where  ra = '" + tempra + "';", bdConn); //O comando usado do banco
                    pesq = sqlcode.ExecuteReader(); //executa o comando acima
                    existe = pesq.Read();
                    pesq.Close();
                    if (existe)
                    {
                        MessageBox.Show("RA já cadastrado");
                    }



                    else if ((tempnomealuno.Length) == 0)
                    {
                        MessageBox.Show("Campo NOME está vazio");
                    }


                    else if ((tempcidade.Length) == 0)
                    {
                        MessageBox.Show("Campo CIDADE está vazio");
                    }


                    else if ((tempestado.Length) == 0)
                    {
                        MessageBox.Show("Campo ESTADO de origem não selecionado");
                    }


                    else if ((tempnacionalidade.Length) == 0)
                    {
                        MessageBox.Show("Campo NACIONALIDADE está vazio");
                    }



                    else if ((tempnascimento.Length) < 10)
                    {
                        MessageBox.Show("Campo NASCIMENTO vazio ou incompleto");
                    }


                    else if ((tempsexo.Length) == 0)
                    {
                        MessageBox.Show("Campo SEXO não selecionado");
                    }


                    else if ((tempmae.Length) == 0)
                    {
                        MessageBox.Show("Campo MÃE vazio");
                    }


                    else if ((templogradouro.Length) == 0)
                    {
                        MessageBox.Show("Campo LOGRADOURO vazio");
                    }


                    else if ((tempnumerolog.Length) == 0)
                    {
                        MessageBox.Show("Campo NÚMERO do logradouro vazio, caso não existir, coloque o número 0");
                    }


                    else if ((tempbairro.Length) == 0)
                    {
                        MessageBox.Show("Campo BAIRRO vazio");
                    }


                    else if ((tempseriepret.Length) == 0)
                    {
                        MessageBox.Show("Campo SÉRIE PRETENDIDA não selecionado");
                    }


                    else if ((tempgraupret.Length) == 0)
                    {
                        MessageBox.Show("Campo GRAU PRETENDIDO não selecionado");
                    }


                    else if ((tempestudou.Length) == 0)
                    {
                        MessageBox.Show("Campo ESTUDOU AQUI não selecionado");
                    }


                    else if ((tempano.Length) < 4)
                    {
                        MessageBox.Show("Campo ANO incompleto ou vazio");
                    }


                    else if ((tempTurno.Length) == 0)
                    {
                        MessageBox.Show("Campo TURNO não selecionado");
                    }


                    else if ((tempgrau.Length) == 0)
                    {
                        MessageBox.Show("Campo GRAU não selecionado");
                    }


                    else if ((tempserie.Length) == 0)
                    {
                        MessageBox.Show("Campo SÉRIE não selecionado");
                    }


                    else if ((tempturma.Length) == 0)
                    {
                        MessageBox.Show("Campo TURMA não selecionado");
                    }

                    //MessageBox.Show("" + temp.Trim().Length );

                    else if ((temp.Trim().Length == 11 && Valida(temp) == false) || temp.Trim().Length > 0 && temp.Trim().Length < 11)
                    {
                        MessageBox.Show("CPF inválido ou incompleto");
                    }

                    else
                    {
                        //if (temp.Trim().Length > 0)
                        
                            sqlcode = new MySqlCommand("Select * from aluno where cpf = '" + maskedTextBox1.Text + "';", bdConn); //O comando usado do banco
                            pesq = sqlcode.ExecuteReader(); //executa o comando acima
                            existe = pesq.Read();
                            pesq.Close();
                            if ((existe) && temp.Trim().Length > 3)
                            {
                                MessageBox.Show("CPF já cadastrado ");
                            }
                            //}



                            //se estiver completo, entra um if else, no if verifica se é verdadeiro

                            else if ((temprm.Length) >= 4 && (tempra.Length) >= 8 && (tempnomealuno.Length) != 0 && (tempcidade.Length) != 0 && (tempestado.Length) != 0
                           && (tempsexo.Length) != 0 && (tempmae.Length) != 0 && (templogradouro.Length) != 0 && (tempnumerolog.Length) != 0
                           && (tempbairro.Length) != 0 && (tempseriepret.Length) >= 0 && (tempgraupret.Length) != 0
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
                                                    + "num_logradouro,complemento,bairro,telefone,"
                                                    + "observacao,escola_anterior,serie_ant,grau_anterior,"
                                                    + "cidade_anterior,estado_anterior,serie_pretendida,grau_pretendido,"
                                                    + "estudou_aqui,ano,turnoT,graug,serieS,turmat,numeroN)"
                                       + "VALUES('" + rm + "','" + ra + "','" + nomealuno + "','" + cidadenascimento + "','"
                                       + nacionalidade + "','" + estadonascimento + "','" + nascimento + "','" + sexo + "','"
                                       + rg + "','" + cpf + "','" + nomemae + "','" + nomepai + "','"
                                       + logradouro + "','" + numerolog + "','" + complemento + "','" + bairro + "','"
                                       + telefonefixo + "','"
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
                                    bttNovo.Enabled = true;
                                    bttSalvar.Enabled = false;
                                    bttAltRM.Enabled = true;
                                    bttAltRA.Enabled = true;
                                    bttAltCPF.Enabled = true;

                                }
                            }
                        }
                    }

                    //pesq.Close();
                }
            }
        
        
       
        //Novo
        private void bttlimp_Click(object sender, EventArgs e)
        {
            txtrm.Enabled = true;
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

                bttSalvarAlt.Enabled = false;
                bttImprimir.Enabled = false;
                bttAlterar.Enabled = false;
                bttSalvar.Enabled = true;
                txtrm.Enabled = true;
            
         }
              
        
        //alterar
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            txtnomealuno.Enabled = true;
            txtcidade.Enabled = true;
            txtestado.Enabled = true;
            txtnacionalidade.Enabled = true;
            txtnascimento.Enabled = true;
            txtsexo.Enabled = true;
            txtrg.Enabled = true;
            //maskedTextBox1.Enabled = true;
            txtmae.Enabled = true;
            txtpai.Enabled = true;
            txtlogradouro.Enabled = true;
            txtnumerolog.Enabled = true;
            txtcomplemento.Enabled = true;
            txtbairro.Enabled = true;
            txtfixo.Enabled = true;
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
            bttNovo.Enabled = false;
            bttImprimir.Enabled = false;
            bttAltCPF.Enabled = false;
            bttAltRA.Enabled = false;
            bttAltRM.Enabled = false;


        }

        //salvar alterações
        private void bttSalvarAlt_Click(object sender, EventArgs e)
        {
            String temp = maskedTextBox1.Text.Replace(",", "").Replace("-", "").Replace(".", "");
            Valida(temp);
            String temprm = txtrm.Text;
            String tempra = txtra.Text;
            String tempnomealuno = txtnomealuno.Text;
            String tempcidade = txtcidade.Text;
            String tempestado = txtestado.Text;
            String tempnacionalidade = txtnacionalidade.Text;
            String tempnascimento = txtnascimento.Text;
            String tempsexo = txtsexo.Text;
            String tempmae = txtmae.Text;
            String templogradouro = txtlogradouro.Text;
            String tempnumerolog = txtnumerolog.Text;
            String tempbairro = txtbairro.Text;
            String tempcpf = maskedTextBox1.Text;
            String tempseriepret = txtseriepret.Text;
            String tempgraupret = txtgraupret.Text;
            String tempestudou = txtestudou.Text;
            String tempano = txtano.Text;
            String tempTurno = txtTurno.Text;
            String tempgrau = txtgrau.Text;
            String tempserie = txtserie.Text;
            String tempturma = txtturma.Text;



          

            if ((temprm.Length) < 4)
            {
                MessageBox.Show("Campo RM está vazio ou incompleto");

            }

           
            else if ((tempra.Length) < 8)
            {
                MessageBox.Show("Campo RA está vazio ou incompleto");
            }


            else if ((tempnomealuno.Length) == 0)
            {
                MessageBox.Show("Campo nome está vazio");
            }


            else if ((tempcidade.Length) == 0)
            {
                MessageBox.Show("Campo CIDADE está vazio");
            }


            else if ((tempestado.Length) == 0)
            {
                MessageBox.Show("Campo ESTADO de origem não selecionado");
            }


            else if ((tempnacionalidade.Length) == 0)
            {
                MessageBox.Show("Campo NACIONALIDADE está vazio");
            }



            else if ((tempnascimento.Length) < 10)
            {
                MessageBox.Show("Campo NASCIMENTO vazio ou incompleto");
            }


            else if ((tempsexo.Length) == 0)
            {
                MessageBox.Show("Campo SEXO não selecionado");
            }


            else if ((tempmae.Length) == 0)
            {
                MessageBox.Show("Campo MÃE vazio");
            }


            else if ((templogradouro.Length) == 0)
            {
                MessageBox.Show("Campo LOGRADOURO vazio");
            }


            else if ((tempnumerolog.Length) == 0)
            {
                MessageBox.Show("Campo NÚMERO do logradouro vazio, caso não existir, coloque o número 0");
            }


            else if ((tempbairro.Length) == 0)
            {
                MessageBox.Show("Campo BAIRRO vazio");
            }


            else if ((tempseriepret.Length) == 0)
            {
                MessageBox.Show("Campo SÉRIE PRETENDIDA não selecionado");
            }


            else if ((tempgraupret.Length) == 0)
            {
                MessageBox.Show("Campo GRAU PRETENDIDO não selecionado");
            }


            else if ((tempestudou.Length) == 0)
            {
                MessageBox.Show("Campo ESTUDOU AQUI não selecionado");
            }


            else if ((tempano.Length) < 4)
            {
                MessageBox.Show("Campo ANO incompleto ou vazio");
            }


            else if ((tempTurno.Length) == 0)
            {
                MessageBox.Show("Campo TURNO não selecionado");
            }


            else if ((tempgrau.Length) == 0)
            {
                MessageBox.Show("Campo GRAU não selecionado");
            }


            else if ((tempserie.Length) == 0)
            {
                MessageBox.Show("Campo SÉRIE não selecionado");
            }


            else if ((tempturma.Length) == 0)
            {
                MessageBox.Show("Campo TURMA não selecionado");
            }



            else if ((temp.Trim().Length == 11 && Valida(temp) == false) || temp.Trim().Length > 0 && temp.Trim().Length < 11)
            {

                {
                    MessageBox.Show("CPF inválido ou incompleto");
                }
            }


                //se estiver completo, entra um if else, no if verifica se é verdadeiro

            else if ((temprm.Length) >= 4 && (tempra.Length) >= 8 && (tempnomealuno.Length) != 0 && (tempcidade.Length) != 0 && (tempestado.Length) != 0
                && (tempsexo.Length) != 0 && (tempmae.Length) != 0 && (templogradouro.Length) != 0 && (tempnumerolog.Length) != 0
                && (tempbairro.Length) != 0 && (tempseriepret.Length) >= 0 && (tempgraupret.Length) != 0
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

                    if (txtrm.Enabled == true)
                    {
                        var sqlcode = new MySqlCommand("Select * from aluno where  rm = " + temprm + ";", bdConn); //O comando usado do banco
                        MySqlDataReader pesq = sqlcode.ExecuteReader(); //executa o comando acima
                        Boolean existe = pesq.Read();
                        pesq.Close();
                        if (existe)
                        {
                            MessageBox.Show("RM já cadastrado");
                            bttImprimir.Enabled = false;
                            
                        }

                        else
                        {
                            String sqlrm = "UPDATE aluno set rm= " + rm + " where ra='" + tempra + "';";
                            MessageBox.Show("RM alterado");
                            bttImprimir.Enabled = true;
                            MySqlCommand commS = new MySqlCommand(sqlrm, bdConn);
                            commS.BeginExecuteNonQuery();
                        }
                    }

                    else if (txtra.Enabled == true) 
                    {
                        var sqlcode = new MySqlCommand("Select * from aluno where  ra = '" + tempra + "';", bdConn); //O comando usado do banco
                        MySqlDataReader pesq = sqlcode.ExecuteReader(); //executa o comando acima
                        Boolean existe = pesq.Read();
                        pesq.Close();
                        if (existe)
                        {
                            MessageBox.Show("RA já cadastrado");
                            bttImprimir.Enabled = false;
                        }

                        else
                        {
                            String sqlra = "UPDATE aluno set ra= '" + ra + "' where rm='" + rm + "';";
                            MessageBox.Show("RA alterado");
                            bttImprimir.Enabled = true;
                            MySqlCommand commS = new MySqlCommand(sqlra, bdConn);
                            commS.BeginExecuteNonQuery();
                        } 
                    }

                    else if (maskedTextBox1.Enabled == true)
                    {                      
                        
                            var sqlcode = new MySqlCommand("Select * from aluno where  cpf = '" + tempcpf + "';", bdConn); //O comando usado do banco
                            MySqlDataReader pesq = sqlcode.ExecuteReader(); //executa o comando acima
                            Boolean existe = pesq.Read();
                            pesq.Close();
                            
                                if ((existe) && temp.Trim().Length > 3)
                                {
                                    MessageBox.Show("CPF já cadastrado");
                                    bttImprimir.Enabled = false;
                                }
                        
                                    
                            else
                            {
                                String sqlcpf = "UPDATE aluno set cpf= '" + cpf + "' where rm='" + rm + "';";
                                MessageBox.Show("CPF alterado");
                                bttImprimir.Enabled = true;
                                MySqlCommand commS = new MySqlCommand(sqlcpf, bdConn);
                                commS.BeginExecuteNonQuery();
                            }
                    }

                    else
                    {
                        //Se estiver aberta insere os dados na BD
                        String sql = "UPDATE aluno SET nome='" + nomealuno + "',cidade_nascimento='" + cidadenascimento + "',"
                                     + "nacionalidade='" + nacionalidade + "',estado='" + estadonascimento + "',"
                                     + "data_nascimento='" + nascimento + "',sexo='" + sexo + "',rg='" + rg + "',"
                                     + "nome_mae='" + nomemae + "',nome_pai='" + nomepai + "',logradouro='" + logradouro + "',"
                                     + "num_logradouro='" + numerolog + "',complemento='" + complemento + "',"
                                     + "bairro='" + bairro + "',telefone='" + telefonefixo + "',observacao='" + observacao + "',"
                                     + "escola_anterior='" + escolaanterior + "',serie_ant='" + serieanterior + "',"
                                     + "grau_anterior='" + grauanterior + "',cidade_anterior='" + cidadeanterior + "',"
                                     + "estado_anterior='" + estadoanterior + "',serie_pretendida='" + seriepretendida + "',"
                                     + "grau_pretendido='" + graupretendido + "',estudou_aqui='" + estudou_aqui + "',"
                                     + "ano='" + ano + "',turnoT='" + turno + "',graug='" + grau + "',serieS='" + serie + "',"
                                     + "turmat='" + turma + "',numeroN='" + numero + "'where rm='" + rm + "';";
                        // String sql = "UPDATE aluno SET nome=\"JOSEFINA\" where rm=\"1111211111\";";
                        //  String sql = "UPDATE aluno SET nome=\"JOSEFINA ZE\" where rm=\"1545435346\";";


                        //String sql;                                            

                        //sql = "UPDATE aluno SET nome='" + nomealuno + "' WHERE rm='" + rm + "';";


                        MessageBox.Show("Alterações Salvas");
                        bttImprimir.Enabled = true;
                        MySqlCommand commS = new MySqlCommand(sql, bdConn);
                        commS.BeginExecuteNonQuery();

                    }
                    
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
                    
                    bttNovo.Enabled = true;
                    bttSalvar.Enabled = false;
                    bttSalvarAlt.Enabled = false;
                    bttAltRA.Enabled = true;
                    bttAltRM.Enabled = true;
                    bttAltCPF.Enabled = true;

                }
            }
        }

        private void bttImprimir_Click(object sender, EventArgs e)
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;

            //Caminho para encontrar o relatório
            reportViewer.LocalReport.ReportEmbeddedResource = "secraorg.relatorioaluno.rdlc";

            //Parâmetros do relatório
            List<ReportParameter> listReportParameter = new List<ReportParameter>();
            listReportParameter.Add(new ReportParameter("Nome", txtnomealuno.Text));
            listReportParameter.Add(new ReportParameter("RM", txtrm.Text));
            listReportParameter.Add(new ReportParameter("RA", txtra.Text));
            listReportParameter.Add(new ReportParameter("Sexo", txtsexo.Text));
            listReportParameter.Add(new ReportParameter("Data", txtnascimento.Text));
            listReportParameter.Add(new ReportParameter("Mae", txtmae.Text));
            listReportParameter.Add(new ReportParameter("Pai", txtpai.Text));
            listReportParameter.Add(new ReportParameter("CidadeNascimento", txtcidade.Text));
            listReportParameter.Add(new ReportParameter("Estado", txtestado.Text));
            listReportParameter.Add(new ReportParameter("Nacionalidade", txtnacionalidade.Text));
            listReportParameter.Add(new ReportParameter("Logradouro", txtlogradouro.Text));
            listReportParameter.Add(new ReportParameter("NumeroLog", txtnumerolog.Text));
            listReportParameter.Add(new ReportParameter("Bairro", txtbairro.Text));
            listReportParameter.Add(new ReportParameter("Observacao", txtobs.Text));
            listReportParameter.Add(new ReportParameter("Escolaant", txtescolaanterior.Text));
            listReportParameter.Add(new ReportParameter("Grauant", txtgrauant.Text));
            listReportParameter.Add(new ReportParameter("Serieant", txtserieant.Text));
            listReportParameter.Add(new ReportParameter("Cidadeant", txtcidadeant.Text));
            listReportParameter.Add(new ReportParameter("Estadoant", txtestadoant.Text));
            listReportParameter.Add(new ReportParameter("Estudou", txtestudou.Text));
            listReportParameter.Add(new ReportParameter("Anopret", txtseriepret.Text));
            listReportParameter.Add(new ReportParameter("Graupret", txtgraupret.Text));
            listReportParameter.Add(new ReportParameter("Ano", txtano.Text));
            listReportParameter.Add(new ReportParameter("Turno", txtTurno.Text));
            listReportParameter.Add(new ReportParameter("Grau", txtgrau.Text));
            listReportParameter.Add(new ReportParameter("Serie", txtserie.Text));
            listReportParameter.Add(new ReportParameter("turma", txtturma.Text));
            listReportParameter.Add(new ReportParameter("Numero", txtnumero.Text));
            listReportParameter.Add(new ReportParameter("Telefone", txtfixo.Text));
           


            
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

        private void CADASTRARALUNO_Load(object sender, EventArgs e)
        {

           
        }

        private void bttAltRM_Click(object sender, EventArgs e)
        {
            txtrm.Enabled = true;

            bttAltCPF.Enabled = false;
            bttAlterar.Enabled = false;
            bttAltRA.Enabled = false;
            bttNovo.Enabled = false;
            bttImprimir.Enabled = false;
            bttSalvarAlt.Enabled = true;
        }

        private void bttAltRA_Click(object sender, EventArgs e)
        {
            txtra.Enabled = true;

            bttAltCPF.Enabled = false;
            bttAlterar.Enabled = false;
            bttAltRM.Enabled = false;
            bttNovo.Enabled = false;
            bttImprimir.Enabled = false;
            bttSalvarAlt.Enabled = true;
            
        }

        private void bttAltCPF_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Enabled = true;

            bttAltRM.Enabled = false;
            bttAlterar.Enabled = false;
            bttAltRA.Enabled = false;
            bttNovo.Enabled = false;
            bttImprimir.Enabled = false;
            bttSalvarAlt.Enabled = true;
        }
      }
 } 

