using UnityEngine;

namespace FlappyBird.Mechanics
{
    [System.Serializable]
    public struct BirdConfig
    {
        public GameObject birdPrefab;
        public Rigidbody2D birdRigidbody;
        public float powerJump;
    }
}