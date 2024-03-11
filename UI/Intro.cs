using StoryGame.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StoryGame.UI
{
    public class Intro
    {
        
        public static void intro() {
            Shortcuts.ClearTheScreen();
            //color of the text
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nWelcome to the beginning of the end...\n\n" +
                "In this sorry world of pain, you can't help but to hate...\n\n" +
                "Please when playing this game, try to only press the enter key to\n" +
                "keep the confusion to a bare minimum. I hope you make it back.......\n" +
                "ALIVE!!");
            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();
            
        }
       
        

        

       
    }
}
