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

using Microsoft.Speech.Recognition;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        private SpeechRecognitionEngine engine;
        private bool isLuna = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadSpeech()
        {
            try
            {
              
                
                engine = new SpeechRecognitionEngine();
                engine.SetInputToDefaultAudioDevice();//microfone
                //string[] words = { "Olá", "Boa Noite" };

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

                // comando para parar de ouvir e voultar a ouvir

                GrammarBuilder gb_commandsOfSystem = new GrammarBuilder();
                gb_commandsOfSystem.Append(c_commandsOfSystem);

                Grammar g_commandsofSystem = new Grammar(gb_commandsOfSystem);
                g_commandsofSystem.Name = "sys";

                Grammar g_comandos = new Grammar(gb_commandsOfSystem);
                g_commandsofSystem.Name = "cmd";

                GrammarBuilder gbNumero = new GrammarBuilder();
                gbNumero.Append(cNumeros);
                gbNumero.Append(new Choices("vezes", "mais", "menos", "por"));
                gbNumero.Append(cNumeros);

                Grammar gNumero = new Grammar(gbNumero);
                gNumero.Name = "calc";

                engine.LoadGrammar(gNumero);
                engine.LoadGrammar(g_commandsofSystem);
                engine.LoadGrammar(g_comandos);

                
                //engine.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(words))));

                engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec);

                engine.AudioLevelUpdated += new EventHandler<AudioLevelUpdatedEventArgs>(audioLevel);

                engine.SpeechRecognitionRejected += new EventHandler<SpeechRecognitionRejectedEventArgs>(rej);

                engine.RecognizeAsync(RecognizeMode.Multiple);// inicia o reconhecimento

                Speech.speak("Estou carregando os arquivos.");
            }
            catch(Exception ex)
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
            Speech.speak("Já carreguei os arquivos, estou pronta!");
            SerialArduino.Open();
            SerialArduino.Write("B");
            SerialArduino.Close();
            // if (SerialArduino.IsOpen())
        }

        private void rec (object s, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;
            float conf = e.Result.Confidence;
            /*string data = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-"+ DateTime.Now.Year.ToString();

            string log_filename = "log\\"+ data + ".txt";
            StreamWriter sw = File.AppendText(log_filename);

            if (File.Exists(log_filename))
            {
                sw.WriteLine(speech);
            }
            else
            {
                sw.WriteLine(speech);
            }
            sw.Close();*/
           
            if (conf > 0.35f)
            {

                if (GrammarRules.LunaisStopListenig.Any(x=> x == speech))
                {
                    isLuna = false;
                }
               /* if (GrammarRules.LunaisStopListenig.Any(x => x == speech)){
                    isLuna = false;
                }*/
                else if(GrammarRules.LunaisStartListening.Any(x => x == speech))
                {
                    isLuna = true;
                    Speech.speak("Olá", "Olá, tudo bom", "Estou aqui", "Estou ouvindo");
                }
                else if (GrammarRules.Ligar.Any(x => x == speech)&& (isLuna == true))
                { 
                    
                    SerialArduino.Open();
                    SerialArduino.Write("A");
                    Speech.speak("Lampada Desligada", "Tudo bem");
                    //Speech.speak("Lampada Acesa", "Que haja luz");
                    SerialArduino.Close();
                }
                else if (GrammarRules.Desligar.Any(x => x == speech) && (isLuna == true))
                {
                    
                    SerialArduino.Open();
                    SerialArduino.Write("B");
                    Speech.speak("Lampada Ligada","Tudo bem", "Que haja luz");
                    //Speech.speak("Lampada Desligada", "Viva na escuridão");
                    SerialArduino.Close();
                }



                if (isLuna == true)
                {
                    switch (e.Result.Grammar.Name)
                    {
                        case "sys":
                            if (GrammarRules.whatTimeIS.Any(x => x == speech))
                            {
                                Ranner.WhatTimeIs();
                            }
                            else if (GrammarRules.WhatDateIs.Any(x => x == speech))
                            {
                                Ranner.WhatDateIs();
                            }
                            else if(GrammarRules.Minimize.Any(x => x == speech)){
                                Minimize();
                            }
                            else if (GrammarRules.Normal.Any(x => x == speech))
                            {
                                Normal();
                            }

                            break;
                        case "calc":
                           // Speech.speak(Calc.Calculo(speech));
                                break;

                      /* case "cmd":
                            if (GrammarRules.Ligar.Any(x => x == speech))
                            {
                                Ligar();
                                
                                
                            }
                            else if (GrammarRules.Desligar.Any(x => x == speech))
                            {
                                Desligar();
                            }
                                break;*/

                    }
                }
            }
        }


        private void audioLevel(object s, AudioLevelUpdatedEventArgs e)
        {
            this.progressBar1.Maximum = 100;
            this.progressBar1.Value = e.AudioLevel;
        }

        private void rej (object s, SpeechRecognitionRejectedEventArgs e)
        {

        }

        private void Minimize()
        {
            if(this.WindowState == FormWindowState.Normal || this.WindowState == FormWindowState.Maximized)
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
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                Speech.speak("Tudo bem", "Janela normal");
            }
            else
            {
                Speech.speak("a janela já está em tamanho normal", "já foi feito");
            }
        }

        /*private void Ligar()
        {
            SerialArduino.Open();
            SerialArduino.Write("A");
            Speech.speak("Lampada Acesa", "Que haja luz");
            SerialArduino.Close()
        }*/

        /*private void Desligar()
        {
            SerialArduino.Open();
            SerialArduino.Write("B");
            Speech.speak("Lampada Desligada", "Viva na escuridão");
            SerialArduino.Close();
        }*/
    }
}
