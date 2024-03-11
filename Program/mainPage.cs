
using StoryGame.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Program
{
    class mainPage
    {
        public static void Main(string[] args)
        {
            //set title
            Console.Title = "Story Time";
            //clear consol
            Console.Clear();
            //run intro prompt
            Intro.intro();
            //run main prompt
            Plot.plot();



        }
    }
}
