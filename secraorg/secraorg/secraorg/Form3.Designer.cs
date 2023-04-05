namespace secraorg
{
    partial class CADASTRARUSUARIO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.codusu = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.declaraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.declaraçãoSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passeProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.háVagasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prontuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prontuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(589, 225);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(401, 20);
            this.txtnome.TabIndex = 2;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            this.txtnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnome_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(589, 292);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CADASTRAR USUÁRIO";
            // 
            // txtusu
            // 
            this.txtusu.Location = new System.Drawing.Point(589, 162);
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(39, 20);
            this.txtusu.TabIndex = 1;
            // 
            // codusu
            // 
            this.codusu.AutoSize = true;
            this.codusu.Location = new System.Drawing.Point(496, 165);
            this.codusu.Name = "codusu";
            this.codusu.Size = new System.Drawing.Size(68, 13);
            this.codusu.TabIndex = 87;
            this.codusu.Text = "Cód. Usuário";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.declaraçãoToolStripMenuItem,
            this.pesquisaToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip2.TabIndex = 89;
            this.menuStrip2.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.turmaToolStripMenuItem,
            this.professorToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // turmaToolStripMenuItem
            // 
            this.turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
            this.turmaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.turmaToolStripMenuItem.Text = "Turma";
            this.turmaToolStripMenuItem.Click += new System.EventHandler(this.turmaToolStripMenuItem_Click_1);
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.professorToolStripMenuItem.Text = "Professor";
            this.professorToolStripMenuItem.Click += new System.EventHandler(this.professorToolStripMenuItem_Click_1);
            // 
            // declaraçãoToolStripMenuItem
            // 
            this.declaraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.declaraçãoSimplesToolStripMenuItem,
            this.passeProfessorToolStripMenuItem,
            this.háVagasToolStripMenuItem});
            this.declaraçãoToolStripMenuItem.Name = "declaraçãoToolStripMenuItem";
            this.declaraçãoToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.declaraçãoToolStripMenuItem.Text = "Declaração";
            // 
            // declaraçãoSimplesToolStripMenuItem
            // 
            this.declaraçãoSimplesToolStripMenuItem.Name = "declaraçãoSimplesToolStripMenuItem";
            this.declaraçãoSimplesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.declaraçãoSimplesToolStripMenuItem.Text = "Simples";
            this.declaraçãoSimplesToolStripMenuItem.Click += new System.EventHandler(this.declaraçãoSimplesToolStripMenuItem_Click);
            // 
            // passeProfessorToolStripMenuItem
            // 
            this.passeProfessorToolStripMenuItem.Name = "passeProfessorToolStripMenuItem";
            this.passeProfessorToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.passeProfessorToolStripMenuItem.Text = "Transferência";
            this.passeProfessorToolStripMenuItem.Click += new System.EventHandler(this.passeProfessorToolStripMenuItem_Click);
            // 
            // háVagasToolStripMenuItem
            // 
            this.háVagasToolStripMenuItem.Name = "háVagasToolStripMenuItem";
            this.háVagasToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.háVagasToolStripMenuItem.Text = "Há Vagas";
            this.háVagasToolStripMenuItem.Click += new System.EventHandler(this.háVagasToolStripMenuItem_Click);
            // 
            // pesquisaToolStripMenuItem
            // 
            this.pesquisaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turmaToolStripMenuItem1,
            this.prontuárioToolStripMenuItem,
            this.prontuárioToolStripMenuItem1});
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pesquisaToolStripMenuItem.Text = "Pesquisar";
            // 
            // turmaToolStripMenuItem1
            // 
            this.turmaToolStripMenuItem1.Name = "turmaToolStripMenuItem1";
            this.turmaToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.turmaToolStripMenuItem1.Text = "Aluno";
            this.turmaToolStripMenuItem1.Click += new System.EventHandler(this.alunoToolStripMenuItem1_Click);
            // 
            // prontuárioToolStripMenuItem
            // 
            this.prontuárioToolStripMenuItem.Name = "prontuárioToolStripMenuItem";
            this.prontuárioToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.prontuárioToolStripMenuItem.Text = "Turma";
            // 
            // prontuárioToolStripMenuItem1
            // 
            this.prontuárioToolStripMenuItem1.Name = "prontuárioToolStripMenuItem1";
            this.prontuárioToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.prontuárioToolStripMenuItem1.Text = "Prontuário";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.configuraçõesToolStripMenuItem.Text = "Gerenciar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 90;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(589, 259);
            this.maskedTextBox1.Mask = "000.000.000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // CADASTRARUSUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.codusu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label1);
            this.Name = "CADASTRARUSUARIO";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CADASTRARUSUARIO_FormClosing);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtusu;
        private System.Windows.Forms.Label codusu;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem declaraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem declaraçãoSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passeProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem háVagasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prontuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prontuárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}