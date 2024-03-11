using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryGame.UI
{
    internal class Plot
    {
        //plot of the story
        public static void plot()
        {
            Console.WriteLine("\n\nToday seems like a good day, you wake up feeling well rested and optimistic.\n" +
                "As you walk to your apartments balcony you call for your dog \nbut he doesn't come to greet you like normal." +
                "You made it to the balcony, \nand as you sip on your coffee you notice a foul smell.");

            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();

            string text = "\n\n\"Damn what the hell is that smell? I wonder if my neighbors left their compost open again.\"\n\n";
            Shortcuts.CharacterVoice(text);
            Shortcuts.PressKeyToContinue();

            Console.WriteLine("You start to light a cigarette but get distracted by a disrupting sound inside your apartment.\n\n" +
                "Quickly turning around, you realize it's just your dog that has been missing at the start of the morning.");

            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();

            text = "\n\n\"What's up Pebbles, where the hell you been boy?\"";
            Shortcuts.CharacterVoice(text);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\n*bark bark*\n\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("While smoking your cigarette you hear a loud screech like sound" +
                "\ntowards the front of the complex.\n");

            Shortcuts.PressKeyToContinue();

            
            string choiceText = "type the number associated with the action you want to do\n" +
                "1. Go investigate | 2. Go about feeling unbothered";
            int choice = Shortcuts.ChoiceShortcut(choiceText);
           
            if (choice == 1)
            {
                Shortcuts.ClearTheScreen();
                Fork.Choice_1();

                Console.WriteLine("\nyou immediately call the police and tell them the story, " +
                    "\nthey send out an investigation crew and ambulances." +
                    "\nThe police come back with no answers but more questions for you, " +
                    "\nyou finish giving them more info, but after you inform them about the strange screech, " +
                    "\nthe officers quickly wrapped up the questioning and vacated the premises.");
                Shortcuts.PressKeyToContinue();
                Console.WriteLine("Before they pull off one of the officers roll down the window to tell you something. ");
                Shortcuts.PressKeyToContinue();
                Shortcuts.ClearTheScreen();
                text = "\n“Hey kid, if you ever hear that screech again run in the opposite direction and don’t turn around.";
                string text2 = "it’s not safe wherever that screech is coming from.. Whatever it’s coming from..”";
                Shortcuts.secondCharacterVoice(text);
                Shortcuts.PressKeyToContinue();
                Shortcuts.secondCharacterVoice(text2);
                Shortcuts.PressKeyToContinue();
                Shortcuts.ClearTheScreen();
                Console.WriteLine("\n\nThe officers pull off but you’re still traumatized from what just happened." +
                    "\nYou decide you should call your parents and hopefully they will have some words of wisdom for you to calm down. " +
                    "\nYou call but no answer, you decide to call 2 more times but no answer still. " +
                    "\nYou go to dial your parents one more time when suddenly you hear that loud annoying screech again, " +
                    "\nthis time though it’s echoed with 4 additional screeches in the same direction where your parents live. ");
                Shortcuts.PressKeyToContinue();

                choiceText = "type the number associated with the action you want to do\n" +
                "1. Check on your parents | 2. Call the police to help you check on your parents";
                choice = Shortcuts.ChoiceShortcut(choiceText);

                if (choice == 1)
                {
                    Fork.CheckOnParents();
                }
                else
                {
                    Fork.CallPolice();
                }




            }
            else
            {
                Shortcuts.ClearTheScreen();
                Fork.Choice_2();
            }
        }
    }
}
