

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


        public HighScore()
        {
            scoresAsString = File.ReadAllLines(filePath);
            scoresAsArrayList.AddRange(scoresAsString); 
        }

        public void addScore(String name, int newScore)
        {
            if (checkForHighScore(newScore))
            {
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

        private Boolean isListFull()
        {
            if (scores.Length >= 10)
            {
                return true;
            }
            return false;
        }

        private void writeToFile()
        {
            File.WriteAllLines(filePath, scoresAsArrayList);
        }

        public string[] getNames()
        {
            string[] splitString;
            string[] names = setStartingState();
            int nameIndex = 0;
            for (int i = scoresAsArrayList.Count - 1; i >= 0; i--)
            {
                splitString = scoresAsArrayList.ElementAt(i).Split(' ');
                names[nameIndex++] = splitString[0];
            }
            return names;
        }

        
        public string[] getScores()
        {
            string[] splitString;
            string[] scores = setStartingState();
            int scoreIndex = 0;
            for (int i = scoresAsArrayList.Count - 1; i >= 0; i--)
            {
                splitString = scoresAsArrayList.ElementAt(i).Split(' ');
                scores[scoreIndex++] = splitString[1];
            }
            return scores;
        }
        

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
