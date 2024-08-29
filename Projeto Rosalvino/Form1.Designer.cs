
namespace Projeto_Rosalvino
{
    partial class Frm_Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastro));
            this.Btn_Ativar = new System.Windows.Forms.Button();
            this.Btn_Desativar = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.Label();
            this.Grp_Temas = new System.Windows.Forms.GroupBox();
            this.Rad_Tema2 = new System.Windows.Forms.RadioButton();
            this.Rad_Tema1 = new System.Windows.Forms.RadioButton();
            this.Rad_Padrão = new System.Windows.Forms.RadioButton();
            this.Grp_Formulario = new System.Windows.Forms.GroupBox();
            this.Btn_Email = new System.Windows.Forms.Button();
            this.Btn_Celular = new System.Windows.Forms.Button();
            this.Btn_Bairro = new System.Windows.Forms.Button();
            this.Btn_Idade = new System.Windows.Forms.Button();
            this.Btn_Sobrenome = new System.Windows.Forms.Button();
            this.Btn_Nome = new System.Windows.Forms.Button();
            this.Lbl_Email = new System.Windows.Forms.TextBox();
            this.Lbl_Celular = new System.Windows.Forms.TextBox();
            this.Lbl_Bairro = new System.Windows.Forms.TextBox();
            this.Lbl_Idade = new System.Windows.Forms.TextBox();
            this.Lbl_Sobrenome = new System.Windows.Forms.TextBox();
            this.Lbl_Nome = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.Label();
            this.Txt_Celular = new System.Windows.Forms.Label();
            this.Txt_Bairro = new System.Windows.Forms.Label();
            this.Txt_Idade = new System.Windows.Forms.Label();
            this.Txt_Sobrenome = new System.Windows.Forms.Label();
            this.Btn_DadosCompletos = new System.Windows.Forms.Button();
            this.Txt_Resultado = new System.Windows.Forms.Label();
            this.Grp_Temas.SuspendLayout();
            this.Grp_Formulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Ativar
            // 
            this.Btn_Ativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Ativar.Location = new System.Drawing.Point(9, 9);
            this.Btn_Ativar.Name = "Btn_Ativar";
            this.Btn_Ativar.Size = new System.Drawing.Size(84, 22);
            this.Btn_Ativar.TabIndex = 0;
            this.Btn_Ativar.Text = "Ativar";
            this.Btn_Ativar.UseVisualStyleBackColor = true;
            this.Btn_Ativar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Desativar
            // 
            this.Btn_Desativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Desativar.Enabled = false;
            this.Btn_Desativar.Location = new System.Drawing.Point(108, 8);
            this.Btn_Desativar.Name = "Btn_Desativar";
            this.Btn_Desativar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Desativar.TabIndex = 1;
            this.Btn_Desativar.Text = "Desativar";
            this.Btn_Desativar.UseVisualStyleBackColor = true;
            this.Btn_Desativar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Limpar.Enabled = false;
            this.Btn_Limpar.Location = new System.Drawing.Point(200, 8);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Limpar.TabIndex = 2;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(92, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dados Pessoais";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.AutoSize = true;
            this.Txt_Nome.Enabled = false;
            this.Txt_Nome.Location = new System.Drawing.Point(20, 60);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(35, 13);
            this.Txt_Nome.TabIndex = 6;
            this.Txt_Nome.Text = "Nome";
            // 
            // Grp_Temas
            // 
            this.Grp_Temas.Controls.Add(this.Rad_Tema2);
            this.Grp_Temas.Controls.Add(this.Rad_Tema1);
            this.Grp_Temas.Controls.Add(this.Rad_Padrão);
            this.Grp_Temas.Enabled = false;
            this.Grp_Temas.Location = new System.Drawing.Point(669, 9);
            this.Grp_Temas.Name = "Grp_Temas";
            this.Grp_Temas.Size = new System.Drawing.Size(316, 62);
            this.Grp_Temas.TabIndex = 7;
            this.Grp_Temas.TabStop = false;
            this.Grp_Temas.Text = "Temas";
            // 
            // Rad_Tema2
            // 
            this.Rad_Tema2.AutoSize = true;
            this.Rad_Tema2.BackColor = System.Drawing.Color.Transparent;
            this.Rad_Tema2.Location = new System.Drawing.Point(216, 34);
            this.Rad_Tema2.Name = "Rad_Tema2";
            this.Rad_Tema2.Size = new System.Drawing.Size(61, 17);
            this.Rad_Tema2.TabIndex = 2;
            this.Rad_Tema2.TabStop = true;
            this.Rad_Tema2.Text = "Tema 2";
            this.Rad_Tema2.UseVisualStyleBackColor = false;
            this.Rad_Tema2.CheckedChanged += new System.EventHandler(this.Rad_Tema2_CheckedChanged);
            // 
            // Rad_Tema1
            // 
            this.Rad_Tema1.AutoSize = true;
            this.Rad_Tema1.Location = new System.Drawing.Point(115, 34);
            this.Rad_Tema1.Name = "Rad_Tema1";
            this.Rad_Tema1.Size = new System.Drawing.Size(61, 17);
            this.Rad_Tema1.TabIndex = 1;
            this.Rad_Tema1.TabStop = true;
            this.Rad_Tema1.Text = "Tema 1";
            this.Rad_Tema1.UseVisualStyleBackColor = true;
            this.Rad_Tema1.CheckedChanged += new System.EventHandler(this.Rad_Tema1_CheckedChanged);
            // 
            // Rad_Padrão
            // 
            this.Rad_Padrão.AutoSize = true;
            this.Rad_Padrão.Location = new System.Drawing.Point(15, 34);
            this.Rad_Padrão.Name = "Rad_Padrão";
            this.Rad_Padrão.Size = new System.Drawing.Size(59, 17);
            this.Rad_Padrão.TabIndex = 0;
            this.Rad_Padrão.TabStop = true;
            this.Rad_Padrão.Text = "Padrão";
            this.Rad_Padrão.UseVisualStyleBackColor = true;
            this.Rad_Padrão.CheckedChanged += new System.EventHandler(this.Rad_Padrão_CheckedChanged);
            // 
            // Grp_Formulario
            // 
            this.Grp_Formulario.BackColor = System.Drawing.Color.Transparent;
            this.Grp_Formulario.Controls.Add(this.Btn_Email);
            this.Grp_Formulario.Controls.Add(this.Btn_Celular);
            this.Grp_Formulario.Controls.Add(this.Btn_Bairro);
            this.Grp_Formulario.Controls.Add(this.Btn_Idade);
            this.Grp_Formulario.Controls.Add(this.Btn_Sobrenome);
            this.Grp_Formulario.Controls.Add(this.Btn_Nome);
            this.Grp_Formulario.Controls.Add(this.Lbl_Email);
            this.Grp_Formulario.Controls.Add(this.Lbl_Celular);
            this.Grp_Formulario.Controls.Add(this.Lbl_Bairro);
            this.Grp_Formulario.Controls.Add(this.Lbl_Idade);
            this.Grp_Formulario.Controls.Add(this.Lbl_Sobrenome);
            this.Grp_Formulario.Controls.Add(this.Lbl_Nome);
            this.Grp_Formulario.Controls.Add(this.Txt_Email);
            this.Grp_Formulario.Controls.Add(this.Txt_Celular);
            this.Grp_Formulario.Controls.Add(this.Txt_Bairro);
            this.Grp_Formulario.Controls.Add(this.Txt_Idade);
            this.Grp_Formulario.Controls.Add(this.Txt_Sobrenome);
            this.Grp_Formulario.Controls.Add(this.label3);
            this.Grp_Formulario.Controls.Add(this.Txt_Nome);
            this.Grp_Formulario.Enabled = false;
            this.Grp_Formulario.Location = new System.Drawing.Point(330, 12);
            this.Grp_Formulario.Name = "Grp_Formulario";
            this.Grp_Formulario.Size = new System.Drawing.Size(333, 220);
            this.Grp_Formulario.TabIndex = 8;
            this.Grp_Formulario.TabStop = false;
            this.Grp_Formulario.Text = "Formulário";
            // 
            // Btn_Email
            // 
            this.Btn_Email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Email.Enabled = false;
            this.Btn_Email.Location = new System.Drawing.Point(230, 189);
            this.Btn_Email.Name = "Btn_Email";
            this.Btn_Email.Size = new System.Drawing.Size(75, 23);
            this.Btn_Email.TabIndex = 23;
            this.Btn_Email.Text = "E-mail";
            this.Btn_Email.UseVisualStyleBackColor = true;
            this.Btn_Email.Click += new System.EventHandler(this.Btn_Email_Click);
            // 
            // Btn_Celular
            // 
            this.Btn_Celular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Celular.Enabled = false;
            this.Btn_Celular.Location = new System.Drawing.Point(230, 163);
            this.Btn_Celular.Name = "Btn_Celular";
            this.Btn_Celular.Size = new System.Drawing.Size(75, 23);
            this.Btn_Celular.TabIndex = 22;
            this.Btn_Celular.Text = "Celular";
            this.Btn_Celular.UseVisualStyleBackColor = true;
            this.Btn_Celular.Click += new System.EventHandler(this.Btn_Celular_Click);
            // 
            // Btn_Bairro
            // 
            this.Btn_Bairro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Bairro.Enabled = false;
            this.Btn_Bairro.Location = new System.Drawing.Point(230, 134);
            this.Btn_Bairro.Name = "Btn_Bairro";
            this.Btn_Bairro.Size = new System.Drawing.Size(75, 23);
            this.Btn_Bairro.TabIndex = 21;
            this.Btn_Bairro.Text = "Bairro";
            this.Btn_Bairro.UseVisualStyleBackColor = true;
            this.Btn_Bairro.Click += new System.EventHandler(this.button8_Click);
            // 
            // Btn_Idade
            // 
            this.Btn_Idade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Idade.Enabled = false;
            this.Btn_Idade.Location = new System.Drawing.Point(230, 107);
            this.Btn_Idade.Name = "Btn_Idade";
            this.Btn_Idade.Size = new System.Drawing.Size(75, 23);
            this.Btn_Idade.TabIndex = 20;
            this.Btn_Idade.Text = "Idade";
            this.Btn_Idade.UseVisualStyleBackColor = true;
            this.Btn_Idade.Click += new System.EventHandler(this.Btn_Idade_Click);
            // 
            // Btn_Sobrenome
            // 
            this.Btn_Sobrenome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Sobrenome.Enabled = false;
            this.Btn_Sobrenome.Location = new System.Drawing.Point(230, 78);
            this.Btn_Sobrenome.Name = "Btn_Sobrenome";
            this.Btn_Sobrenome.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sobrenome.TabIndex = 19;
            this.Btn_Sobrenome.Text = "Sobrenome";
            this.Btn_Sobrenome.UseVisualStyleBackColor = true;
            this.Btn_Sobrenome.Click += new System.EventHandler(this.Btn_Sobrenome_Click);
            // 
            // Btn_Nome
            // 
            this.Btn_Nome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Nome.Enabled = false;
            this.Btn_Nome.Location = new System.Drawing.Point(230, 50);
            this.Btn_Nome.Name = "Btn_Nome";
            this.Btn_Nome.Size = new System.Drawing.Size(75, 23);
            this.Btn_Nome.TabIndex = 18;
            this.Btn_Nome.Text = "Nome";
            this.Btn_Nome.UseVisualStyleBackColor = true;
            this.Btn_Nome.Click += new System.EventHandler(this.button5_Click);
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Email.Enabled = false;
            this.Lbl_Email.Location = new System.Drawing.Point(96, 189);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(105, 20);
            this.Lbl_Email.TabIndex = 17;
            // 
            // Lbl_Celular
            // 
            this.Lbl_Celular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Celular.Enabled = false;
            this.Lbl_Celular.Location = new System.Drawing.Point(96, 163);
            this.Lbl_Celular.Name = "Lbl_Celular";
            this.Lbl_Celular.Size = new System.Drawing.Size(105, 20);
            this.Lbl_Celular.TabIndex = 16;
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Bairro.Enabled = false;
            this.Lbl_Bairro.Location = new System.Drawing.Point(96, 138);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(105, 20);
            this.Lbl_Bairro.TabIndex = 15;
            // 
            // Lbl_Idade
            // 
            this.Lbl_Idade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Idade.Enabled = false;
            this.Lbl_Idade.Location = new System.Drawing.Point(96, 110);
            this.Lbl_Idade.Name = "Lbl_Idade";
            this.Lbl_Idade.Size = new System.Drawing.Size(105, 20);
            this.Lbl_Idade.TabIndex = 14;
            this.Lbl_Idade.TextChanged += new System.EventHandler(this.Label_Idade_TextChanged);
            // 
            // Lbl_Sobrenome
            // 
            this.Lbl_Sobrenome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Sobrenome.Enabled = false;
            this.Lbl_Sobrenome.Location = new System.Drawing.Point(96, 82);
            this.Lbl_Sobrenome.Name = "Lbl_Sobrenome";
            this.Lbl_Sobrenome.Size = new System.Drawing.Size(105, 20);
            this.Lbl_Sobrenome.TabIndex = 13;
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Nome.Enabled = false;
            this.Lbl_Nome.Location = new System.Drawing.Point(96, 53);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(105, 20);
            this.Lbl_Nome.TabIndex = 12;
            // 
            // Txt_Email
            // 
            this.Txt_Email.AutoSize = true;
            this.Txt_Email.Enabled = false;
            this.Txt_Email.Location = new System.Drawing.Point(20, 189);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(35, 13);
            this.Txt_Email.TabIndex = 11;
            this.Txt_Email.Text = "E-mail";
            // 
            // Txt_Celular
            // 
            this.Txt_Celular.AutoSize = true;
            this.Txt_Celular.Enabled = false;
            this.Txt_Celular.Location = new System.Drawing.Point(20, 163);
            this.Txt_Celular.Name = "Txt_Celular";
            this.Txt_Celular.Size = new System.Drawing.Size(39, 13);
            this.Txt_Celular.TabIndex = 10;
            this.Txt_Celular.Text = "Celular";
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.AutoSize = true;
            this.Txt_Bairro.Enabled = false;
            this.Txt_Bairro.Location = new System.Drawing.Point(20, 138);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(34, 13);
            this.Txt_Bairro.TabIndex = 9;
            this.Txt_Bairro.Text = "Bairro";
            // 
            // Txt_Idade
            // 
            this.Txt_Idade.AutoSize = true;
            this.Txt_Idade.Enabled = false;
            this.Txt_Idade.Location = new System.Drawing.Point(20, 113);
            this.Txt_Idade.Name = "Txt_Idade";
            this.Txt_Idade.Size = new System.Drawing.Size(34, 13);
            this.Txt_Idade.TabIndex = 8;
            this.Txt_Idade.Text = "Idade";
            // 
            // Txt_Sobrenome
            // 
            this.Txt_Sobrenome.AutoSize = true;
            this.Txt_Sobrenome.Enabled = false;
            this.Txt_Sobrenome.Location = new System.Drawing.Point(20, 85);
            this.Txt_Sobrenome.Name = "Txt_Sobrenome";
            this.Txt_Sobrenome.Size = new System.Drawing.Size(61, 13);
            this.Txt_Sobrenome.TabIndex = 7;
            this.Txt_Sobrenome.Text = "Sobrenome";
            // 
            // Btn_DadosCompletos
            // 
            this.Btn_DadosCompletos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DadosCompletos.Enabled = false;
            this.Btn_DadosCompletos.Font = new System.Drawing.Font("Curlz MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DadosCompletos.Location = new System.Drawing.Point(453, 238);
            this.Btn_DadosCompletos.Name = "Btn_DadosCompletos";
            this.Btn_DadosCompletos.Size = new System.Drawing.Size(94, 54);
            this.Btn_DadosCompletos.TabIndex = 9;
            this.Btn_DadosCompletos.Text = "Dados Completos";
            this.Btn_DadosCompletos.UseVisualStyleBackColor = true;
            this.Btn_DadosCompletos.Click += new System.EventHandler(this.Btn_DadosCompletos_Click);
            // 
            // Txt_Resultado
            // 
            this.Txt_Resultado.AutoSize = true;
            this.Txt_Resultado.Enabled = false;
            this.Txt_Resultado.Location = new System.Drawing.Point(71, 391);
            this.Txt_Resultado.Name = "Txt_Resultado";
            this.Txt_Resultado.Size = new System.Drawing.Size(55, 13);
            this.Txt_Resultado.TabIndex = 10;
            this.Txt_Resultado.Text = "Resultado";
            this.Txt_Resultado.Click += new System.EventHandler(this.label8_Click);
            // 
            // Frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Rosalvino.Properties.Resources.BANNER_SITE_CEDESP_MATRICULAS_2024_2025;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(925, 469);
            this.Controls.Add(this.Txt_Resultado);
            this.Controls.Add(this.Btn_DadosCompletos);
            this.Controls.Add(this.Grp_Formulario);
            this.Controls.Add(this.Grp_Temas);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Btn_Desativar);
            this.Controls.Add(this.Btn_Ativar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Cadastro";
            this.Text = "Cadastro";
            this.Grp_Temas.ResumeLayout(false);
            this.Grp_Temas.PerformLayout();
            this.Grp_Formulario.ResumeLayout(false);
            this.Grp_Formulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Ativar;
        private System.Windows.Forms.Button Btn_Desativar;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Txt_Nome;
        private System.Windows.Forms.GroupBox Grp_Temas;
        private System.Windows.Forms.RadioButton Rad_Tema2;
        private System.Windows.Forms.RadioButton Rad_Tema1;
        private System.Windows.Forms.RadioButton Rad_Padrão;
        private System.Windows.Forms.GroupBox Grp_Formulario;
        private System.Windows.Forms.Button Btn_Email;
        private System.Windows.Forms.Button Btn_Celular;
        private System.Windows.Forms.Button Btn_Bairro;
        private System.Windows.Forms.Button Btn_Idade;
        private System.Windows.Forms.Button Btn_Sobrenome;
        private System.Windows.Forms.Button Btn_Nome;
        private System.Windows.Forms.TextBox Lbl_Email;
        private System.Windows.Forms.TextBox Lbl_Celular;
        private System.Windows.Forms.TextBox Lbl_Bairro;
        private System.Windows.Forms.TextBox Lbl_Idade;
        private System.Windows.Forms.TextBox Lbl_Sobrenome;
        private System.Windows.Forms.TextBox Lbl_Nome;
        private System.Windows.Forms.Label Txt_Email;
        private System.Windows.Forms.Label Txt_Celular;
        private System.Windows.Forms.Label Txt_Bairro;
        private System.Windows.Forms.Label Txt_Idade;
        private System.Windows.Forms.Label Txt_Sobrenome;
        private System.Windows.Forms.Button Btn_DadosCompletos;
        private System.Windows.Forms.Label Txt_Resultado;
    }
}

