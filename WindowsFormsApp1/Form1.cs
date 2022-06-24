using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;
using Microsoft.Speech.Recognition;
using System.Speech.Synthesis;
using System.Globalization;
using System.Threading;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private SpeechRecognitionEngine engine;
        private bool isLuna = true;
        LoginDaoComandos loginDao = new LoginDaoComandos();
        String usuario;
        String pass;
        bool botaoEditar = false;


        static CultureInfo ci = new CultureInfo("pt-BR");
        public Form1(String login, String senha)
        {
            usuario = login;
            pass = senha;
            InitializeComponent();
            MenuDeslizante.Width = 68;

        }



        private void LoadSpeech()
        {
            try
            {

                engine = new SpeechRecognitionEngine(ci);
                engine.SetInputToDefaultAudioDevice();


                Choices cNumeros = new Choices();
                for (int i = 0; i <= 100; i++)
                    cNumeros.Add(i.ToString());

                //carregar gramatica
                Choices c_commandsOfSystem = new Choices();
                c_commandsOfSystem.Add(GrammarRules.whatTimeIS.ToArray());
                c_commandsOfSystem.Add(GrammarRules.WhatDateIs.ToArray());
                c_commandsOfSystem.Add(GrammarRules.LunaisStartListening.ToArray());
                c_commandsOfSystem.Add(GrammarRules.LunaisStopListenig.ToArray());
                c_commandsOfSystem.Add(GrammarRules.Minimize.ToArray());
                c_commandsOfSystem.Add(GrammarRules.Normal.ToArray());
                c_commandsOfSystem.Add(GrammarRules.Ligar.ToArray());
                c_commandsOfSystem.Add(GrammarRules.Desligar.ToArray());
                c_commandsOfSystem.Add(GrammarRules.nome.ToArray());
                c_commandsOfSystem.Add(GrammarRules.face.ToArray());
                c_commandsOfSystem.Add(GrammarRules.pesquisa.ToArray());
                c_commandsOfSystem.Add(GrammarRules.youtube.ToArray());
                c_commandsOfSystem.Add(GrammarRules.ventiladoron.ToArray());
                c_commandsOfSystem.Add(GrammarRules.ventiladoroff.ToArray());
                c_commandsOfSystem.Add(GrammarRules.garagemop.ToArray());
                c_commandsOfSystem.Add(GrammarRules.garagemclose.ToArray());
                c_commandsOfSystem.Add(GrammarRules.celularon.ToArray());
                c_commandsOfSystem.Add(GrammarRules.celularoff.ToArray());
                c_commandsOfSystem.Add(GrammarRules.blackout.ToArray());
                c_commandsOfSystem.Add(GrammarRules.sair.ToArray());



                GrammarBuilder gb_commandsOfSystem = new GrammarBuilder();
                gb_commandsOfSystem.Append(c_commandsOfSystem);

                Grammar g_commandsofSystem = new Grammar(gb_commandsOfSystem);
                g_commandsofSystem.Name = "sys";

                Grammar g_comandos = new Grammar(gb_commandsOfSystem);
                g_commandsofSystem.Name = "cmd";




                engine.LoadGrammar(g_commandsofSystem);
                engine.LoadGrammar(g_comandos);



                engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(reco);

                engine.AudioLevelUpdated += new EventHandler<AudioLevelUpdatedEventArgs>(audioLevel);

                engine.SpeechRecognitionRejected += new EventHandler<SpeechRecognitionRejectedEventArgs>(rej);

                engine.RecognizeAsync(RecognizeMode.Multiple);// inicia o reconhecimento

                Speech.speak("Olá, como vai?.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu no LoadSpeech(): " + ex.Message);
            }
        }

        private void Engine_SpeechRecognized1(object sender, SpeechRecognizedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Engine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSpeech();
            Speech.speak(" Serei sua assistente, me chamo Luna, é um prazer!");
            //SerialArduino.Open();
            //SerialArduino.Write("Z");               //                        <<<<<<<<<<<<<<<-----------------------------------------------------ARDUINO 
            //SerialArduino.Close();
            // if (SerialArduino.IsOpen()) responsavel pelo arduino  
        }

        private void reco(object s, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;
            float conf = e.Result.Confidence;
            string data = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            string hora = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();


            string log_filename = "log\\" + data + ".txt";
            StreamWriter sw = File.AppendText(log_filename);


            if (File.Exists(log_filename))
            {
                sw.WriteLine("Usuário: " + usuario + " - " + " Comando: " + speech + " - " + "Hora:" + hora);

            }
            else
            {
                sw.WriteLine("Usuário: " + usuario + " - " + " Comando: " + speech + " - " + "Hora:" + hora);

            }
            sw.Close(); // função para criar txt com falas

            if (conf > 0f)
            {
                loginDao.logusuario(usuario, speech, data, hora);
                if (GrammarRules.LunaisStopListenig.Any(x => x == speech))
                {
                    isLuna = false;
                }
                else if (GrammarRules.LunaisStartListening.Any(x => x == speech))
                {
                    isLuna = true;
                    Speech.speak("Olá", "Olá, tudo bom", "Estou aqui", "Estou ouvindo");
                }
                else if (GrammarRules.Desligar.Any(x => x == speech) && (isLuna == true))
                {

                    int result = loginDao.Permissaoluz(usuario, pass);
                    if (result == 1)
                    {
                        SerialArduino.Open();
                        SerialArduino.Write("L");
                        Speech.speak("Tudo bem", "Como quiser, Senhor", "Lampada Ligada");
                        SerialArduino.Close();
                    }
                    else
                    {
                        Speech.speak("Você não tem permissão de Administrador!");
                    }
                }
                else if (GrammarRules.Ligar.Any(x => x == speech) && (isLuna == true))
                {
                    //   <<<<<<<<<<<<<<<<-----------------------------------------------------ARDUINO 
                    int result = loginDao.Permissaoluz(usuario, pass);
                    if (result == 1)
                    {
                        SerialArduino.Open();
                        SerialArduino.Write("A");
                        Speech.speak("Tudo bem", "Como quiser, Senhor", "Lampada Ligada");
                        SerialArduino.Close();
                    }
                    else
                    {
                        Speech.speak("Você não tem permissão de Administrador!");
                    }
                }
                else if (GrammarRules.ventiladoron.Any(x => x == speech) && (isLuna == true))
                {
                    int result = loginDao.PermissaoVent(usuario, pass);
                    if (result == 1)
                    {
                        SerialArduino.Open();
                        SerialArduino.Write("B");
                        Speech.speak("Tudo bem", "Como quiser, Senhor");
                        SerialArduino.Close();
                    }
                    else
                    {
                        Speech.speak("Você não tem permissão de Administrador!");
                    }
                }
                else if (GrammarRules.ventiladoroff.Any(x => x == speech) && (isLuna == true))
                {
                    //   <<<<<<<<<<<<<<<<-----------------------------------------------------ARDUINO 
                    int result = loginDao.PermissaoVent(usuario, pass);
                    if (result == 1)
                    {
                        SerialArduino.Open();
                        SerialArduino.Write("V");
                        Speech.speak("Tudo bem", "Como quiser, Senhor");
                        SerialArduino.Close();
                    }
                    else
                    {
                        Speech.speak("Você não tem permissão de Administrador!");
                    }
                }
                else if (GrammarRules.garagemop.Any(x => x == speech) && (isLuna == true))
                {
                    int result = loginDao.PermissaoGaragem(usuario, pass);
                    if (result == 1)

                    {
                        SerialArduino.Open();
                        SerialArduino.Write("C");
                        Speech.speak("Boa Viagem", "Tudo bem", "Como quiser, Senhor");
                        SerialArduino.Close();
                    }
                    else
                    {
                        Speech.speak("Você não tem permissão de Administrador!");
                    }
                }
                else if (GrammarRules.garagemclose.Any(x => x == speech) && (isLuna == true))
                {
                    //   <<<<<<<<<<<<<<<<-----------------------------------------------------ARDUINO 

                    int result = loginDao.PermissaoGaragem(usuario, pass);
                    if (result == 1)

                    {
                        SerialArduino.Open();
                        SerialArduino.Write("G");
                        Speech.speak("Boa Viagem", "Tudo bem", "Como quiser, Senhor");
                        SerialArduino.Close();
                    }
                    else
                    {
                        Speech.speak("Você não tem permissão de Administrador!");
                    }
                }
                else if (GrammarRules.celularon.Any(x => x == speech) && (isLuna == true))
                {

                    int result = loginDao.PermissaoCelular(usuario, pass);
                    if (result == 1)
                    {
                        SerialArduino.Open();
                        SerialArduino.Write("D");
                        Speech.speak("Carregando celular", "Tudo bem", "Como quiser, Senhor");
                        SerialArduino.Close();
                    }
                    else
                    {
                        Speech.speak("Você não tem permissão de Administrador!");
                    }
                }
                else if (GrammarRules.celularoff.Any(x => x == speech) && (isLuna == true))
                {
                    //   <<<<<<<<<<<<<<<<-----------------------------------------------------ARDUINO 
                    int result = loginDao.PermissaoCelular(usuario, pass);
                    if (result == 1)
                    {
                        SerialArduino.Open();
                        SerialArduino.Write("S");
                        Speech.speak("Carregando celular", "Tudo bem", "Como quiser, Senhor");
                        SerialArduino.Close();
                    }
                    else
                    {
                        Speech.speak("Você não tem permissão de Administrador!");
                    }
                }
                else if (GrammarRules.blackout.Any(x => x == speech) && (isLuna == true))
                {
                    //   <<<<<<<<<<<<<<<<-----------------------------------------------------ARDUINO 
                    SerialArduino.Open();
                    SerialArduino.Write("L");
                    SerialArduino.Write("V");
                    SerialArduino.Write("S");
                    Speech.speak("Tudo bem", "Como quiser, Senhor");
                    SerialArduino.Close();
                }
                else if (GrammarRules.whatTimeIS.Any(x => x == speech) && (isLuna == true))
                {
                    Ranner.WhatTimeIs();
                }
                else if (GrammarRules.whatTimeIS.Any(x => x == speech) && (isLuna == true))
                {
                    Ranner.WhatTimeIs();
                }
                else if (GrammarRules.WhatDateIs.Any(x => x == speech) && (isLuna == true))
                {
                    Ranner.WhatDateIs();
                }
                else if (GrammarRules.Minimize.Any(x => x == speech) && (isLuna == true))
                {
                    Minimize();
                }
                else if (GrammarRules.Normal.Any(x => x == speech) && (isLuna == true))
                {
                    Normal();
                }
                else if (GrammarRules.nome.Any(x => x == speech) && (isLuna == true))
                {
                    Speech.speak("Meu nome é Luna, em que posso ajudar?", "Me chamo Luna, é um prazer");
                }
                else if (GrammarRules.face.Any(x => x == speech) && (isLuna == true))
                {

                    string url = "https://www.facebook.com";
                    System.Diagnostics.Process.Start(url);
                    //Process.Start("notepad");
                    Speech.speak("Abrindo Facebook");
                }
                else if (GrammarRules.pesquisa.Any(x => x == speech) && (isLuna == true))
                {



                    string url = "https://www.google.com.br";
                    System.Diagnostics.Process.Start(url);
                    Speech.speak("Abrindo Google");

                }


            }
            else if (GrammarRules.youtube.Any(x => x == speech) && (isLuna == true))
            {

                string url = "https://www.youtube.com";
                System.Diagnostics.Process.Start(url);

                Speech.speak("Abrindo o Youtube");
            }
            else if (GrammarRules.sair.Any(x => x == speech) && (isLuna == true))
            {
                Application.Exit();

            }



        }


        private void audioLevel(object s, AudioLevelUpdatedEventArgs e)
        {
            this.progressBar1.Maximum = 100;
            this.progressBar1.Value = e.AudioLevel;
        }

        private void rej(object s, SpeechRecognitionRejectedEventArgs e)
        {

        }

        private void Minimize()
        {
            if (this.WindowState == FormWindowState.Normal || this.WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Minimized;
                Speech.speak("minimizando a janela", "como quiser", "tudo bem");
            }
            else
            {
                Speech.speak("Janela minimizada", "Já fiz essa operação");
            }
        }

        private void Normal()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                Speech.speak("Tudo bem", "Janela normal");
            }
            else
            {
                Speech.speak("a janela já está em tamanho normal", "já foi feito");
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            botaoEditar = false;
            int result = loginDao.PermissaoCadastro(usuario, pass);
            if (result == 1)
            {
                Form3 cadastro = new Form3(usuario, pass);
                LoginDaoComandos id = new LoginDaoComandos();
                id.acharid(usuario, pass);
                cadastro.Show();
            }
            else
            {
                Speech.speak("Voçê não é administrador");
                MessageBox.Show("Voçê não é administrador", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if (MenuDeslizante.Width == 270)
            {
                MenuDeslizante.Width = 68;

            }
            else
            {
                MenuDeslizante.Width = 270;
            }
        }

        private void btnCadastrar_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btnCadastrar_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Leave(object sender, EventArgs e)
        {

        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            int result = loginDao.PermissaoCadastro(usuario, pass);
            if (result == 1)
            {
                ListaClientes.DataSource = loginDao.ListaUsuarios();

            }
            else
            {
                Speech.speak("Voçê não é administrador");
                MessageBox.Show("Voçê não é administrador", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            botaoEditar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            botaoEditar = false;
            int result = loginDao.PermissaoCadastro(usuario, pass);
            if (result == 1)
            {
                ListaClientes.DataSource = loginDao.Log();

            }
            else
            {
                Speech.speak("Voçê não é administrador");
                MessageBox.Show("Voçê não é administrador", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (botaoEditar == true)
            {

                if (ListaClientes.SelectedRows.Count > 0)
                {
                    String nome, senha, confsenha, luz, vent, garagem, celular, cadastrar;
                    nome = ListaClientes.CurrentRow.Cells["nome"].Value.ToString();
                    senha = ListaClientes.CurrentRow.Cells["senha"].Value.ToString();
                    confsenha = ListaClientes.CurrentRow.Cells["senha"].Value.ToString();
                    luz = ListaClientes.CurrentRow.Cells["luz"].Value.ToString();
                    vent = ListaClientes.CurrentRow.Cells["ventilador"].Value.ToString();
                    garagem = ListaClientes.CurrentRow.Cells["garagem"].Value.ToString();
                    celular = ListaClientes.CurrentRow.Cells["celular"].Value.ToString();
                    cadastrar = ListaClientes.CurrentRow.Cells["cadastrar"].Value.ToString();
                    Form4 atualiza = new Form4(nome, senha, confsenha, luz, vent, garagem, celular, cadastrar, usuario, pass);
                    atualiza.Show();


                }
                else
                {
                    MessageBox.Show("Selecione a Linha que deseja alterar!");
                }
                
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (botaoEditar == true)
            {
                if (ListaClientes.SelectedRows.Count > 0)
                {
                    String id = ListaClientes.CurrentRow.Cells["id"].Value.ToString();
                    loginDao.ExcluirPermissao(Convert.ToInt32(id));
                    loginDao.ExcluirCliente(Convert.ToInt32(id));
                    MessageBox.Show("Excluido com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListaClientes.DataSource = loginDao.ListaUsuarios();

                }
                else
                {
                    MessageBox.Show("Selecione a Linha que deseja excluir!");
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            usuario = "";
            pass = "";
            isLuna = false;
            Form2 login = new Form2();
            login.Show();
        }
    }
}
