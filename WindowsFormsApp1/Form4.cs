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
    public partial class Form4 : Form
    {
        String adm = ""; 
        String pass = "";
        String senhaUSU = "";
        String nomeUSU = "";

        public Form4(String nome, String senha, String confsenha, String luz, String vent, String garagem, String celular, String cadastrar, String LoginAdm, String Senhaadm)
        {
            LoginDaoComandos id = new LoginDaoComandos();
            InitializeComponent();
             nomeUSU = nome;
             senhaUSU = senha;
             adm = LoginAdm;
             pass = Senhaadm;
           

                    
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int luz = 0, vent = 0, cel = 0, garagem = 0, cadastrar = 0;
            String mensagem = "Cadastro Atualizado!";
            LoginDaoComandos atualiza = new LoginDaoComandos();
            //String conf = atualiza.Criptografia(edtconfsenha.Text);

            atualiza.atualizarcadastro(nomeUSU, senhaUSU,edtNome.Text,edtsenha.Text , adm, pass);
            
            if (ckLuz.Checked)
            {
                luz = 1;
            }
            if (ckVent.Checked)
            {
                vent = 1;
            }
            if (ckCelular.Checked)
            {
                cel = 1;
            }
            if (ckGaragem.Checked)
            {
                garagem = 1;
            }
            if (ckCadastrar.Checked)
            {
                cadastrar = 1;
            }
            atualiza.atualizarpermi(edtNome.Text, edtsenha.Text, luz, vent, cel, garagem, cadastrar, adm, pass);
            MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
