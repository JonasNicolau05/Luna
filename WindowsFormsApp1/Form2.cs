using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            Form1 principal = new Form1(txtLogin.Text, txtSenha.Text);
            Controle controle = new Controle();
            
            controle.acessar(txtLogin.Text, txtSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com Sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 luna = new Form1(txtLogin.Text, txtSenha.Text);
                    luna.Show();

                    
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

      

        
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Login")
            {
                txtLogin.Text = "";
                txtLogin.ForeColor = Color.DeepSkyBlue;
                
            }
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                linha1.ForeColor = Color.Red;
                txtLogin.Text = "Login";
                txtLogin.ForeColor = Color.DodgerBlue;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.DeepSkyBlue;
                txtSenha.UseSystemPasswordChar = true;
               
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                
                txtSenha.Text = "Senha";
                txtLogin.ForeColor = Color.DodgerBlue;
                txtSenha.UseSystemPasswordChar = false;
                
            }
        }

        private void btnEntrar_MouseUp(object sender, MouseEventArgs e)
        {
             btnEntrar.ForeColor = Color.MidnightBlue;
        }

       
    }
}
