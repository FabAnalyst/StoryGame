using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryGame.UI
{
    internal class Fork
    {
        public static void Choice_1()
        {
            Console.WriteLine("\n\nAs you investigate you peep out the front window " +
                "\nfirst to see if you can see what's going on but you don't see anything," +
                "\nyou open your front door but don't hear anything anymore. " +
                "\nYou walk back inside and turn on the tv while fixing another cup " +
                "of coffee but subconsciously thinking to yourself what in the world that noise could've been.");


            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();

            Console.WriteLine("\n\nCan't shake the feeling, so you decide to take your dog for a walk and see " +
                "\nif maybe you can find out what that loud screech was. Pebbles, looking excited to go out for a walk, " +
                "\nhappily leads the way out the door. You make your way to the front by the gate and notice " +
                "\nthat there's a birthday party going on and quickly assume that the loud screech could've " +
                "\nbeen maybe a kid screaming as they were jumping in the pool.");


            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();

            Console.WriteLine("\n\nDetermined to finish the walk you take pebbles through the gated complex and onto the street.");

            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();
            string text = "\n\n\"It's too damn hot today man, I'm so ready for the fall weather to come.\"";
            Shortcuts.CharacterVoice(text);
            Shortcuts.PressKeyToContinue();

            Console.WriteLine("On your way back you pass by an ally and notice there’s a woman getting chased by a homeless man.");
            Shortcuts.PressKeyToContinue();

            string choiceText = "type the number associated with the action you want to do\n" +
                "1. Save the woman | 2. Call The Cops | 3. RUN";
            int choice = Shortcuts.ChoiceShortcut(choiceText);
            if (choice == 1)
            {
                Hero();
            }
            else if (choice == 2)
            {
                CallThePolice();
            }
            else
            {
                WalkAway();
            }
        }

        public static void Choice_2()
        {
            Shortcuts.ClearTheScreen();
            Console.WriteLine("\n\nGoing about your day, you try not to let anything get into your way.\n" +
                "You start to fix a cup of coffee and turn on the television as you feel unbothered.");
        }

        //choose to be a hero
        public static void Hero()
        {
            Shortcuts.ClearTheScreen();
            Console.WriteLine("\n\nYou tie Pebbles to a near-by post to make sure he stays safe and you break " +
                "\ninto a run towards the woman in distress. As you run closer to the woman, " +
                "\nyou notice that the man chasing her does indeed look homeless.. ");
            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();
            Console.WriteLine("\n\nbut he also had this look in his eyes, " +
                "\na look that can kill the grim reaper himself if he dared to stare long enough." +
                "\nYou manage to intercept this homeless man and bought the lady some time to run away.");
            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();


            String text = "\n\n\"Sir please, just walk away I don't want to fight you.\"";
            Shortcuts.CharacterVoice(text);
            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();

            Console.WriteLine("\n\nAs you pull out your pocket knife you noticed that " +
                "\nhomeless man changed targets almost mindlessly.");
            String choiceText = "\ntype the number associated with the action you want to do\n" +
                "1. stab him in the heart | 2. stab him in the head | 3.stab him in the neck";
            int choice = Shortcuts.ChoiceShortcut(choiceText);

            if (choice == 1)
            {
                Heart();
            }
            else if (choice == 2)
            {
                Brain();
            }
            else
            {
                Neck();
            }

        }

        //choose to call the police
        public static void CallThePolice()
        {
            Shortcuts.ClearTheScreen();
            Console.WriteLine(" ");
        }

        //choose to walk away
        public static void WalkAway()
        {
            Shortcuts.ClearTheScreen();
            Console.WriteLine(" ");
        }

        //stab zombie in the heart
        public static void Heart()
        {
            Shortcuts.ClearTheScreen();
            Console.WriteLine("Unprovoked, you stab the homeless man in the heart," +
                "\nand he stops for just a moment and tries to bite you.");
            string text = "\"What the FUCK bro back up!\" ";
            Shortcuts.CharacterVoice(text);
            Shortcuts.PressKeyToContinue();
            Console.WriteLine("\n\nTry again!");
            String choiceText = "\ntype the number associated with the action you want to do\n" +
                "1. stab him in the heart | 2. stab him in the head | 3.stab him in the neck";
            int choice = Shortcuts.ChoiceShortcut(choiceText);

            if (choice == 1)
            {
                Heart();
            }
            else if (choice == 2)
            {
                Brain();
            }
            else
            {
                Neck();
            }

        }

        //stab zombie in the neck
        public static void Neck()
        {
            Shortcuts.ClearTheScreen();
            Console.WriteLine("Unprovoked, you stab the homeless man in the neck ," +
                "\nand he stops for just a moment and tries to bite you.");
            string text = "\n\"Come on dude please just walk away! I don't want to hurt you.\"";
            Shortcuts.CharacterVoice(text);
            Shortcuts.PressKeyToContinue();

            Console.WriteLine("\n\nTry again!");
            String choiceText = "\ntype the number associated with the action you want to do\n" +
                "1. stab him in the heart | 2. stab him in the head | 3.stab him in the neck";
            int choice = Shortcuts.ChoiceShortcut(choiceText);

            if (choice == 1)
            {
                Heart();
            }
            else if (choice == 2)
            {
                Brain();
            }
            else
            {
                Neck();
            }
        }

        public static void Brain()
        {
            Shortcuts.ClearTheScreen();
            Console.WriteLine("Unprovoked, you stab the homeless man in the head and he drops " +
                "\nimmediately to the ground.");
            string text = "\n\"Damnit! I tried to save you man.\" ";
            Shortcuts.CharacterVoice(text);
            Shortcuts.PressKeyToContinue();
            
        }

        //check on parents yourself
        public static void CheckOnParents()
        {
            Shortcuts.ClearTheScreen();
            Console.WriteLine("\n\nImmediately following the screech," +
                "\nwithout hesitation you grab pebbles and speed towards your parents’ house." +
                "\nYou finally get to your parents house and you get out of the vehicle to run in to find your parents,");
            Shortcuts.PressKeyToContinue();
            string text = "“Bark if you see someone coming in the house okay boy?”";
            Shortcuts.CharacterVoice(text);
            Shortcuts.PebblesBark();
            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();
            text = "\n\n“MOM! DAD! ARE YOU HERE?”";
            Shortcuts.CharacterVoice(text);
            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();
            Console.WriteLine("\n\nyou start to hear screaming coming from the back yard, so you rush to help." +
                "\nYou notice a man attacking your 65-year-old dad. ");
            string choiceText = "type the number associated with the action you want to do\n" +
                "1. Stab the man on your dad | 2. Toss your dad your knife";
            int choice = Shortcuts.ChoiceShortcut(choiceText);

            if (choice == 1)
            {
                HelpDad();
            }
            else
            {
                TossKnife();
            }
        }

        //call the police to help you check on your parents
        public static void CallPolice()
        {
            Console.WriteLine(") Immediately following the screech, you and pebbles " +
                "\ndrive to your parents and at the same time you call the police.");
            Shortcuts.PressKeyToContinue();
            string text = "\n“Yes, 9-1-1? I just called not too long ago about the man eating another human alive.”";
            Shortcuts.CharacterVoice(text);
            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();
            Console.WriteLine("you tell them about the screech and request them to send police to your parents house. " +
                "\nYou wait patiently for about 15 minutes and finally the police pull up. " +
                "\nOnce they finished searching the house they come back with a sorry look on their face.");
            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();
            string text2 = "“I’m sorry to be the one to tell you but... both of your parents are dead.”";
            Shortcuts.secondCharacterVoice(text2);
            Shortcuts.PressKeyToContinue();
            Console.WriteLine("\n\nYou stand in disbelief. You stared at the officer for about 3 minutes before bolting in the house. " +
                "\nThe minute you walked in you noticed the blood in the living room. " +
                "\nYou walk into the bedroom and notice your mom on the bed with her guts demolished" +
                "\nand eaten by some sort of beast. ");
            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();
            Console.WriteLine("You start to feel sick; you walk out of the room and followed the blood " +
                "\ntracks to the back of the house where your dad lay still in the grass. " +
                "\nHis face is completely gone but you know it is him because he is wearing the shirt you " +
                "\nbought him for his birthday. ");
            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();
            text = "“If only I would have come sooner, I probably could have saved them. This is all my fault.”";
            Shortcuts.CharacterVoice(text);
            Shortcuts.PressKeyToContinue();
            Console.WriteLine("\n.” You start to feel regret, but that is quickly replaced with anger. " +
                "\nYou go back to the officers to let them know that you will be evacuating soon. ");
            Shortcuts.PressKeyToContinue();
            Console.WriteLine("The officers advise you to evacuate to the military base west of Houston.");
            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();
            text2 = "“But son I will advise you to find a better weapon than that scrawny knife of yours. " +
                "\nWhat if you get double teamed or even a hoard of these demon spawns? You’re gonna be toast.”";
            Shortcuts.secondCharacterVoice(text2);
            Shortcuts.PressKeyToContinue();
            Console.WriteLine("You walk back and grab your dads gun case key from his office " +
                "\nand collect every single artillery out of the safe. ");
            text = "“He was right, even if I did make it in time could I have even saved my parents?”";
            text2 = "“Screw it... It’s too late now, I promise to dedicate my life to kill all of you damn Zombies my self”";
            Shortcuts.CharacterVoice(text);
            Shortcuts.PressKeyToContinue();
            Shortcuts.CharacterVoice(text2);
        }

        //stab the man on your dad
        public static void HelpDad()
        {
            Console.WriteLine("you killed the man that was on top of your dad..");
            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();
            string text = "\n\n“Dad are you okay?”";
            string text2 = "\n“Yes, son I’m okay, I’m so happy to see you.”";
            Shortcuts.CharacterVoice(text);
            Shortcuts.secondCharacterVoice(text2);
            text = "\n“Where’s mom? We must pack some food and water and get out of here, come on let’s go.”";
            text2 = "\n“Wait son there’s something you need to know.”";
            Shortcuts.PressKeyToContinue();
            Shortcuts.CharacterVoice(text);
            Shortcuts.secondCharacterVoice(text2);
            text = "\n“We can talk when we’re all in the car we just don’t have time right now, " +
                "\nI don’t know what’s going on but all I know is we have to –.”";
            text2 = "\n“Son your mother was killed about 15 minutes ago. " +
                "\nShe was attacked by this man, and I was not here to protect her. " +
                "\nI was gone for just a moment to get some milk and eggs and I come back, " +
                "\nand she is getting eaten alive by this… this… DEVIL!”";
            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();
            Console.WriteLine(" …. There was a moment of silence...");
            Shortcuts.PressKeyToContinue();
            Console.WriteLine("it felt as though someone had reached inside your chest and pulled out your " +
                "\nheart to just throw it in the dirt in front of you. " +
                "\nIf only you had gotten there sooner, you could have saved mom.");
            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();
            text = "\n\n“So, what do we do now dad?”";
            text2 = "\n“We still need to evacuate, the news put out an emergency report" +
                "\nabout half an hour ago about a group of zombies or," +
                "\nor cannibals or something going around town eating people alive.”";
            Shortcuts.CharacterVoice(text);
            Shortcuts.secondCharacterVoice(text2);
            Shortcuts.PressKeyToContinue();
            text = "“But where do we go? Is anywhere we go going to be safe?”";
            text2 = "\n“We have 2 options; " +
                "\nwe can go to the military base and live there for the time being " +
                "\nor we can travel towards the east coast. I hear they have a bunker that takes refugees. " +
                "\nFrom what I know, they are trying to diagnose these people and see if there’s some sort " +
                "\nof cure or at least figure out how they turned over.”";
            Shortcuts.CharacterVoice(text);
            Shortcuts.secondCharacterVoice(text2);
            Shortcuts.PressKeyToContinue();
            Shortcuts.ClearTheScreen();
            text = "\n\n“Well, I guess we have to make a decision…”\n";
            Shortcuts.CharacterVoice(text);
            string choiceText = "\ntype the number associated with the action you want to do\n" +
                "1. go to the military base in Houston | 2. Go to the Bunker on the east coast";
            int choice = Shortcuts.ChoiceShortcut(choiceText);
            if (choice == 1)
            {
                Console.WriteLine("Congratulations, you made it through chapter 1");
            }
            else
            {
                Console.WriteLine("Congratulations, you made it through chapter 1");
            }
        }

        //toss your dad the knife to save himself
        public static void TossKnife()
        {
            Shortcuts.ClearTheScreen();
            string text = "\n\n\"Dad catch!\"";

            Shortcuts.CharacterVoice(text);
            //finish this section
        }


    }

}
