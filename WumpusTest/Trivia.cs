using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace WumpusTest
{

    class Trivia
    {

        // instance variables
        private ArrayList questions;
        private int numberOfQuestions;
        int numCorrect = 0;

        public Trivia()
        {
            readTriviaFile();
        }

        private void readTriviaFile()
        {
            String[] lines = Properties.Resources.TriviaQuestions.Trim().Split(Environment.NewLine);
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i].Trim();
            }
            questions = new ArrayList(lines);
            numberOfQuestions = lines.Length / 5;
        }

        public String randomQuestion()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, numberOfQuestions);
            return questions[randomNumber].ToString();

        }

        public Boolean purchaseTrivia()
        {

            return false;
        }

        /*public Boolean arrowTrivia()
        {
            //will be an array
            Console.WriteLine("How many states are there?\n13\n51\n52\n50");
            String answer = reader.next();
            if(answer == "50")
            {
                numCorrect++;
            }
            //ask another question
            if(numCorrect == 2)
            {
                return true;
                //call game control
            }
            return false;
        } */

        public Boolean secretTrivia()
        {
            //asks player trivia questions
            //returns based on number of answers correct
            //if true go to askingSecret
            return true;
        }

        public String askingSecret()
        {
            //secrets contained in an array
            //gives user a hint
            return null;
        }

        public Boolean pitTrivia()
        {
            //asks player trivia questions
            //returns based on number of answers correct
            //informs game control
            return true;
        }
 
    }
}
