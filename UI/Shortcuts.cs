using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StoryGame.UI
{
    internal class Shortcuts
    {
        //continue prompt
        public static void PressKeyToContinue()
        {
            
            Console.WriteLine("\n\n press Enter to continue..\n\n");
            Console.ReadKey();
        }

        //clear screen
        public static void ClearTheScreen()
        {
            Console.Clear();
        }

        //distinct the characters voice
        public static void CharacterVoice(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (char c in text)
            {
                
                Console.Write(c);
                Thread.Sleep(1);

            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        //second characters voice
        public static void secondCharacterVoice(string text2)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (char c in text2)
            {

                Console.Write(c);
                Thread.Sleep(1);

            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        //create a choice to make
        public static int ChoiceShortcut(string choiceText)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(choiceText);

            int choice = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            return choice;
        }

        //pebbles voice
        public static void PebblesBark()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\n*bark*\n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //pebbles voice2
        public static void Pebbles2Bark()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\n*bark bark*\n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
