using UnityEngine;

namespace FlappyBird.Mechanics
{
    [System.Serializable]
    public class GameDataContainer : MonoBehaviour
    {
        public BirdConfig birdConfig;
        public PipeConfig pipeConfig;
        
        public GameCurrence gameCurrence;
        public UIConfig UIConfig;
        [Space]
        public Vector2 birdSpawnPoint;

    }
}