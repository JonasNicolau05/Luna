using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Ranner
    {
        public static void WhatTimeIs()
        {
            Speech.Speak(DateTime.Now.ToLongTimeString());
        }

        public static void WhatDateIs()
        {
            Speech.Speak(DateTime.Now.ToShortDateString());    
        }
    }
}
