using FlappyBird.Mechanics;
using UnityEngine;

namespace Assets
{
    public sealed class Pipe : MonoBehaviour
    {
        private GameDataContainer container;

        private void Awake()
        {
            if (container == null)
                container = FindObjectOfType<GameDataContainer>();
        }

        private void Update() =>
            transform.Translate(container.pipeConfig.pipeSpeed * Time.deltaTime * Vector2.left);
    }
}