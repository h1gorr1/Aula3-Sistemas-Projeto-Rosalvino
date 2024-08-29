using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Rosalvino
{
    public partial class Frm_Cadastro : System.Windows.Forms.Form
    {
        public Frm_Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Btn_Bairro.Enabled = true;
            Btn_Ativar.Enabled = false;
            Btn_Celular.Enabled = true;
            Btn_DadosCompletos.Enabled = true;
            Btn_Desativar.Enabled = true;
            Btn_Email.Enabled = true;
            Btn_Idade.Enabled = true;
            Btn_Limpar.Enabled = true;
            Btn_Nome.Enabled = true;
            Btn_Sobrenome.Enabled = true;
            Txt_Bairro.Enabled = true;
            Txt_Celular.Enabled = true;
            Txt_Email.Enabled = true;
            Txt_Idade.Enabled = true;
            Txt_Nome.Enabled = true;
            Txt_Resultado.Enabled = true;
            Txt_Sobrenome.Enabled = true;
            Lbl_Bairro.Enabled = true;
            Lbl_Celular.Enabled = true;
            Lbl_Email.Enabled = true;
            Lbl_Idade.Enabled = true;
            Lbl_Nome.Enabled = true;
            Lbl_Sobrenome.Enabled = true;
            Grp_Temas.Enabled = true;
            Grp_Formulario.Enabled = true;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Dando o sentido ao botão Desativar, nas labels, grupos de textos e caixas de texto,desativando o formulário
            Btn_Bairro.Enabled = false;
            Btn_Ativar.Enabled = true;
            Btn_Celular.Enabled = false;
            Btn_DadosCompletos.Enabled = false;
            Btn_Desativar.Enabled = false;
            Btn_Email.Enabled = false;
            Btn_Idade.Enabled = false;
            Btn_Limpar.Enabled = false;
            Btn_Nome.Enabled = false;
            Btn_Sobrenome.Enabled = false;
            Txt_Bairro.Enabled = false;
            Txt_Celular.Enabled = false;
            Txt_Email.Enabled = false;
            Txt_Idade.Enabled = false;
            Txt_Nome.Enabled = false;
            Txt_Resultado.Enabled = false;
            Txt_Sobrenome.Enabled = false;
            Lbl_Bairro.Enabled = false;
            Lbl_Celular.Enabled = false;
            Lbl_Email.Enabled = false;
            Lbl_Idade.Enabled = false;
            Lbl_Nome.Enabled = false;
            Lbl_Sobrenome.Enabled = false;
            Grp_Temas.Enabled = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lbl_Nome.Clear();
            Lbl_Sobrenome.Clear();
            Lbl_Email.Clear();
            Lbl_Celular.Clear();
            Lbl_Bairro.Clear();
            Lbl_Idade.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = Lbl_Bairro.Text + "\n";
        }

        private void Rad_Padrão_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.BANNER_SITE_CEDESP_MATRICULAS_2024_2025;
        }

        private void Rad_Tema1_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Dom_Bosco;
        }

        private void Rad_Tema2_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Rosalvino;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = Lbl_Nome.Text + "\n";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Label_Idade_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_DadosCompletos_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = Lbl_Nome.Text + "\n" + Lbl_Sobrenome.Text + "\n" + Lbl_Idade.Text + "\n" + Lbl_Bairro.Text + "\n" + Lbl_Celular.Text + "\n" + Lbl_Email.Text + "\n"; 

        }

        private void Btn_Sobrenome_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = Lbl_Sobrenome.Text + "\n";
        }

        private void Btn_Idade_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = Lbl_Idade.Text + "\n";
        }

        private void Btn_Celular_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = Lbl_Celular.Text + "\n";
        }

        private void Btn_Email_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = Lbl_Email.Text + "\n";
        }
    }
}
