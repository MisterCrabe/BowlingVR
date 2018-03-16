using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._Project.Scripts
{
    public class ScorePanel : MonoBehaviour 
    {
        public Text scoreText;

        private void Start()
        {
            ScoreManager.ScoreChanged += ShowScore;
        }

        private void OnDestroy()
        {
            ScoreManager.ScoreChanged -= ShowScore;
        }


        public void ShowScore()
        {

            scoreText.text = ScoreManager.score.ToString("D3");
        }
        
    }

    
}
