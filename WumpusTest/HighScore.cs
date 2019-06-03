

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WumpusTest
{
    public class HighScore
    {
        // instance variables
        private int[] scores = new int[10];
        private String[] scoresAsString = new String[10];
        private List<string> scoresAsArrayList = new List<string>();
        private string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HighScores.txt"; 

        // constructor loads in scores from a file
        public HighScore() 
        {
            scoresAsString = File.ReadAllLines(filePath);
            scoresAsArrayList.AddRange(scoresAsString); 
        }
        // precondition: Scores have been initialized and name is a valid string and newScore is a valid int
        // postcondition:A score is added to the field scoresAsArrayList
        public void addScore(String name, int newScore)
        {
            if (checkForHighScore(newScore))
            { // if list is full remove lowst number
                if (scoresAsArrayList.Count() >= 10)
                {
                    scoresAsArrayList.RemoveAt(0);
                }
                int scoreAsInt;
                String scoreAsString;
                for (int i = 0; i < scoresAsArrayList.Count; i++)
                {
                    String[] str = scoresAsArrayList.ElementAt(i).Split(new char[] { ' ' });
                    scoreAsString = str[1];
                    scoreAsInt = Int32.Parse(scoreAsString);
                    if (newScore < scoreAsInt)
                    {
                        scoresAsArrayList.Insert(i, name + " " + newScore.ToString());
                        break;
                    }
                }
                writeToFile();
            }
        }
        // checks if the new score is withing the top 10 scores
        private Boolean checkForHighScore(int newScore)
        {
            if (!isListFull())
            {
                return true;
            }
            else
            {
                if (newScore > scores.Last())
                {
                    return true;
                }
                return false;
            }
        }
        // checks if highscore has too many values
        private Boolean isListFull()
        {
            if (scores.Length >= 10)
            {
                return true;
            }
            return false;
        }
        // method to update the highscore file
        private void writeToFile()
        {
            File.WriteAllLines(filePath, scoresAsArrayList);
        }
        // passes just the names of high scorers
        public string[] getNames()
        {
            string[] arrayScores = scoresAsArrayList.ToArray();
            string[] splitString;
            string[] names = setStartingState();
            for (int i = 0; i < arrayScores.Length; i++)
            {
                splitString = arrayScores[i].Split(null);
                names[i] = splitString[0];
            }
            return names;
        }
        // passes the scores as a string array        
        public string[] getScores()
        {
            string[] splitString;
            string[] scores = setStartingState();
            for (int i = 0; i < scoresAsArrayList.Count; i++)
            {
                splitString = scoresAsArrayList.ElementAt(i).Split(' ');
                scores[i] = splitString[1];
            }
            return scores;
        }
        
        // propagates the string array with null values
        private string[] setStartingState()
        {
            string[] arr = new string[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = "None";
            }
            return arr;
        }

    }

}

