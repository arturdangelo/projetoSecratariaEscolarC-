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
    public partial class CADASTRARUSUARIO : Form
    {

        private MySqlConnection bdConn;
        
        public CADASTRARUSUARIO(MySqlConnection conex)
        {
            bdConn = conex;
            InitializeComponent();
        }



        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CADASTRARALUNO cadastroaluno = new CADASTRARALUNO(bdConn, this);
            cadastroaluno.ShowDialog();
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

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void CADASTRARUSUARIO_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)

            //verifica se o maskedtextbox1 que é do campo cpf está totalmente preenchido
            // se estiver incompleto, ele avisa que está incompleto
        {
            string temp = maskedTextBox1.Text.Replace(",", "").Replace("-", "");
            if (maskedTextBox1.Text.Contains(' ') || temp.Length != 11)
            {
                MessageBox.Show("CPF incompleto");
            }

                //se estiver completo, entra um if else, no if verifica se é verdadeiro
            else {
                Valida(temp);
                if (Valida(temp) == true)
                {


                    //Verifica se a conexão está aberta
                    if (bdConn.State == ConnectionState.Open)
                    {
                        String nome = txtnome.Text;
                        String cpf = maskedTextBox1.Text.Replace(",", "").Replace("-", "");
                        String codigo = txtcodigo.Text;

                        //Se estiver aberta insere os dados na BD
                        MySqlCommand commS = new MySqlCommand("INSERT INTO usuario VALUES('" + nome + "','" + cpf + "','" + codigo + "')", bdConn);
                        commS.BeginExecuteNonQuery();

                        MessageBox.Show("Cadastro completo");
                        // se for verdadeiro, ele faz os inserts na tabela usuario do mysql e exibe a mensagem que o cadastro está completo
                    }

                }
                //se não for verdadeiro o cpf, ele exibe essa mensagem abaixo
                else
                {
                    MessageBox.Show("CPF incorreto, favor verificar");

                }

            
            }
          

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

        // colocando tudo maiúsculo
        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            txtnome.CharacterCasing = CharacterCasing.Upper;
        }

        
        // aqui bloqueia os caracteres especiais e outros... os números 32 08 e 127 está incluido no
        // código ascii. para saber mais acesse: http://www.elcodigoascii.com.ar/codigos-ascii/comillas-simples-apostrofes-codigo-ascii-39.html
        private void txtnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar == 32) || (e.KeyChar == 08) || (e.KeyChar == 127)))
            {
                e.Handled = true;
            }

                     
            
        }


    }
}
        

    



    

