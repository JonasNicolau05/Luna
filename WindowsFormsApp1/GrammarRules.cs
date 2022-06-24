using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class GrammarRules
    {
        public static IList<string> whatTimeIS = new List<string>() {

            "Que horas são",
            "Me diga as horas",
            "Poderia me informar as horas",};


        public static IList<string> WhatDateIs = new List<string>()
        {
            "Qual a data de hoje",
            "que dia é hoje",
            "Me informe a data",
            "Estamos em que dia",
        };

        public static IList<string> LunaisStartListening = new List<string>()
        {
            "Luna",
            "Luna você está ai",
            "Olá, Luna",
            "oi Luna"
        };

        public static IList<string> LunaisStopListenig = new List<string>()
        {
            "Pare de ouvir",
            "Pare de me ouvir",
            "Pare de escutar",
            "Fica Quieta",
            "Pare de falar",
            "desativar"
        };

        public static IList<string> Minimize = new List<string>()
        {
            "Minimizar a Janela",
            "Minimize a janela",
            "Luna, minimize a janela"
        };

        public static IList<string> Normal = new List<string>()
        {
            "Janela em tamanho normal",
            "tamanho normal",
            "Restaurar janela"

        };

        public static IList<string> Ligar = new List<string>()
        {
            "Ligar a luz",
            "Ligar lâmpada",
            "Luz"
        };

        public static IList<string> Desligar = new List<string>()
        {
            "Desligar a luz",
            "Apagar lâmpada",
            "Apagar"
           
        };
        public static IList<string> nome = new List<string>()
        {
            "Qual o seu nome",
            "como se chama",
            "quem é você"

        };
        public static IList<string> face = new List<string>()
        {
            "Abrir facebook",
            "facebook"

        };
        public static IList<string> pesquisa = new List<string>()
        {
            "pesquisa",
            "quero pesquisar"

        };
        public static IList<string> youtube = new List<string>()
        {
            "Abrir youtube",
            "youtube",
            "musica"

        };
        public static IList<string> musica = new List<string>()
        {
            "Abrir musica",
            "musica"

        };
        public static IList<string> ventiladoron = new List<string>()
        {
            "Ligar Ventilador",
            "Vento",
            "Ligue o ventilador"

        };
        public static IList<string> ventiladoroff = new List<string>()
        {
            "Desligar Ventilador",
            "Desligue o ventilador"

        };
        public static IList<string> garagemop = new List<string>()
        {
            "Abrir porta da garagem",
            "Abrir Garagem"

        };
        public static IList<string> garagemclose = new List<string>()
        {
            "Fechar porta da garagem",
            "Fechar Garagem"

        };
        public static IList<string> celularon = new List<string>()
        {
            "Ligar Carregador",
            "carregar celular",
            "carregue meu celular"

        };
        public static IList<string> celularoff = new List<string>()
        {
            "Desligar Carregador",
            "parar recarga"

        };
        public static IList<string> blackout  = new List<string>()
        {
            "Desligar tudo",
            "Desligue tudo"

        };
        public static IList<string> sair = new List<string>()
        {
            "fechar",
            "sair",
            "encerrar"
        };
    }
}
