using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public string UsuarioAdm { get; set; }
        public string SenhaAdm { get; set; }
        int luz = 0, vent = 0, cel = 0, garagem = 0, cadastrar = 0;
        
        public Form3(string usuario, string senha)
        {
            UsuarioAdm = usuario;
            SenhaAdm = senha;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            
            int result = loginDao.PermissaoCadastro(UsuarioAdm, SenhaAdm);
            if (result == 1)
            {
               
                if (ckLuz.Checked)
                {
                    luz = 1;
                }
                if (ckVentilador.Checked)
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
                if (ckCadastar.Checked)
                {
                    cadastrar = 1;
                }
                Controle controle = new Controle();
                String mesagem = controle.cadastrar(cdNome.Text, cdSenha.Text, cdConfirma.Text, UsuarioAdm, SenhaAdm, luz, vent, cel, garagem, cadastrar);
                if (controle.tem)
                {
                    MessageBox.Show(mesagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    
                    



                }
                else
                {
                    MessageBox.Show(controle.mensagem);
                }


            }

        }

        private void btnCadastrou_MouseUp(object sender, MouseEventArgs e)
        {
            btnCadastrou.ForeColor = Color.MidnightBlue;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
