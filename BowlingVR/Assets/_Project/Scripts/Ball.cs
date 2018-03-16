using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets._Project.Scripts
{
    public class Ball : MonoBehaviour
    {
        private bool isScored;
        
        public bool IsScored
        {
            get { return isScored; }
            set { isScored = value; }
        }

        private bool isOnTheWay;

        public bool IsOnTheWay
        {
            get { return isOnTheWay; }
            set { isOnTheWay = value; }
        }
    }
}
