using UnityEngine;

namespace FlappyBird.Mechanics
{
    [System.Serializable]
    public struct PipeConfig
    {
        public GameObject pipePrefab;
        public Vector2 pipePosition; // x = -1, y = 4
        public float pipeTimeLife;   // 10 second
        public float pipeSpeed;
        public float timeSpawn;
        public bool isSpawnPipe;
    }
}