using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._Project.Scripts
{
    public static class ScoreManager
    {
        public static int score;
        public static int tempScore;
        public static int[] hitNumber = new int[] { 1, 2 };

        public static Action ScoreChanged;

        public static void UpdateScore(int NbScoredQuilles)
        {

            switch (NbScoredQuilles)
            {
                case 10:
                    CheckTempScore();
                    tempScore = 10;
                    break;

                case 9:
                    CheckTempScore();
                    tempScore = 9;
                    break;

                case 8:
                    CheckTempScore();
                    score += NbScoredQuilles;
                    break;
                case 0:
                    CheckTempScore();
                    break;
            }
            
            if (ScoreChanged != null)
            {
                ScoreChanged.Invoke();
            }
        }



        public static void CheckTempScore()
        {
            if (tempScore != null)
            {
                switch (tempScore)
                {
                    case 10:
                        if (true)
                        {

                        }
                        tempScore = 10;
                        break;

                    case 9:
                        CheckTempScore();
                        tempScore = 9;
                        break;

                    case 8:
                        CheckTempScore();
                        score += NbScoredQuilles;
                        break;
                    case 0:
                        CheckTempScore();
                        break;
                }
            }
        }
    }
}
