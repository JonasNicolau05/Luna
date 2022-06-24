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

        public static IList<string> Desligar = new List<string>()
        {
            "Ligar a luz",
            "Ligar lâmpada",
            "Luz"
        };

        public static IList<string> Ligar = new List<string>()
        {
            "Desligar a luz",
            "Apagar lâmpada",
            "Apagar"
           
        };
    }
}
