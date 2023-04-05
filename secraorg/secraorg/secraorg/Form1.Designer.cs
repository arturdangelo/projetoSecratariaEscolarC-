namespace secraorg
{
    partial class PESQUISARALUNO
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PESQUISARALUNO));
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.declaraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.declaraçãoSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.háVagasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prontuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prontuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pesquisa = new System.Windows.Forms.TextBox();
            this.codusu = new System.Windows.Forms.Label();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "PESQUISA DE ALUNO";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.declaraçãoToolStripMenuItem,
            this.pesquisaToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1109, 24);
            this.menuStrip2.TabIndex = 12;
            this.menuStrip2.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.alunoToolStripMenuItem,
            this.turmaToolStripMenuItem,
            this.professorToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click_1);
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
            this.transferenciaToolStripMenuItem,
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
            // transferenciaToolStripMenuItem
            // 
            this.transferenciaToolStripMenuItem.Name = "transferenciaToolStripMenuItem";
            this.transferenciaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.transferenciaToolStripMenuItem.Text = "Transferência";
            this.transferenciaToolStripMenuItem.Click += new System.EventHandler(this.passeProfessorToolStripMenuItem_Click);
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
            this.prontuárioToolStripMenuItem,
            this.prontuárioToolStripMenuItem1});
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pesquisaToolStripMenuItem.Text = "Pesquisar";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 353);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(163, 148);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(91, 17);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.Text = "Nome da mãe";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(103, 148);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.Text = "Nome";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(52, 147);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 17);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "RM";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pesquisa
            // 
            this.pesquisa.Location = new System.Drawing.Point(52, 185);
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.Size = new System.Drawing.Size(343, 20);
            this.pesquisa.TabIndex = 14;
            this.pesquisa.TextChanged += new System.EventHandler(this.pesquisa_TextChanged);
            // 
            // codusu
            // 
            this.codusu.AutoSize = true;
            this.codusu.Location = new System.Drawing.Point(49, 110);
            this.codusu.Name = "codusu";
            this.codusu.Size = new System.Drawing.Size(68, 13);
            this.codusu.TabIndex = 1;
            this.codusu.Text = "Cód. Usuário";
            // 
            // txtusu
            // 
            this.txtusu.Location = new System.Drawing.Point(161, 107);
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(39, 20);
            this.txtusu.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PESQUISARALUNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1109, 642);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pesquisa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.codusu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PESQUISARALUNO";
            this.Text = "SECRAORG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PESQUISARALUNO_FormClosing);
            this.Load += new System.EventHandler(this.PESQUISARALUNO_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem declaraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem declaraçãoSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem háVagasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prontuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prontuárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pesquisa;
        private System.Windows.Forms.Label codusu;
        private System.Windows.Forms.TextBox txtusu;
        private System.Windows.Forms.ImageList imageList1;
    }
}

