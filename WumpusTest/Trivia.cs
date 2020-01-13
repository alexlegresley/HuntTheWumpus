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
        private Random random = new Random();
        private ArrayList questions;
        private int numberOfQuestions;
        private string[] questionGroup = new string[5];
        private string correctAnswer;

        public Trivia()
        {
            readTriviaFile();
        }

        private void readTriviaFile()
        {
            string[] lines = Properties.Resources.TriviaQuestions.Trim().Split(new[] {System.Environment.NewLine}, StringSplitOptions.None);
            questions = new ArrayList(lines);
            numberOfQuestions = lines.Length / 5;
        }

        // a "question group" is defined as the question and four answer choices, with the first answer choice as listed in the file being the correct answer
        public string[] getRandomQuestionGroup()
        {
            int randomNumber = random.Next(0, numberOfQuestions) * 5;
            int i = 0;
            for (int j = randomNumber; j < randomNumber + 5; j++)
            {
                questionGroup[i] = (string)questions[j];
                i++;
            }
            correctAnswer = questionGroup[1];
            randomizeAnswerChoices();
            return questionGroup;
        }

        // removes the question group from the arraylist to avoid repeated questions
        private void removeQuestion(int startingIndex)
        {
            for (int i = startingIndex; i < startingIndex + 5; i++)
            {
                questions.RemoveAt(i);
            }
            numberOfQuestions = questions.Count / 5;
        }

        // randomizes the answer choices in questionGroup array so that the correct answer no longer appears in a predictable position
        private void randomizeAnswerChoices()
        {
            // fisher-yates shuffle algorithm
            // i begins at 1 instead of 0 since the question is contained at index zero and should not be included in the randomization
            for (int i = 1; i < questionGroup.Length; i++)
            {
                int j = random.Next(i, questionGroup.Length);
                string temp = questionGroup[i];
                questionGroup[i] = questionGroup[j];
                questionGroup[j] = temp; 
            }
        }

        public string getCorrectAnswer()
        {
            return correctAnswer;
        }
 
    }

}
