using UnityEngine;
using UnityEngine.UI;

namespace FlappyBird.Mechanics
{
    [System.Serializable]
    public struct UIConfig
    {
        public Text scoreText;
        public Text score;
        public Text bestScore;
        public GameObject panel;
    }
}