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
        private int[] scores = new int[10];
        private String[] scoresAsString = new String[10];
        private List<string> scoresAsArrayList = new List<string>();

        public HighScore()
        {
            scoresAsString = File.ReadAllLines("HighScores.txt");
            String[] str;
            int score;
            for (int i = 0; i < scoresAsString.Length; i++)
            {
                str = scoresAsString[i].Split(new char[] { ' ' });
                score = Int32.Parse(str[1]);
                scores[i] = score;
            }
            scoresAsArrayList.AddRange(scoresAsString);
        }

        public void displayHighScores()
        {
            for (int i = scoresAsArrayList.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(scoresAsArrayList[i]);
            }
        }

        public Boolean checkForHighScore(int newScore)
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
                else
                {
                    return false;
                }
            }
        }

        public void rearrangeScores(String name, int newScore)
        {
            if (scoresAsArrayList.Count() >= 10)
            {
                scoresAsArrayList.RemoveAt(0);
            }

            for (int i = 0; i < scoresAsArrayList.Count; i++)
            {

                if(newScore < scores[i])
                {
                    scoresAsArrayList.Insert(i, name + " " + newScore.ToString());
                    break;
                }
            }

        }

        public void writeToFile()
        {

            File.WriteAllLines("HighScores.txt", scoresAsArrayList);
            
        }

        public Boolean isListFull()
        {
            if(scores.Length >= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
