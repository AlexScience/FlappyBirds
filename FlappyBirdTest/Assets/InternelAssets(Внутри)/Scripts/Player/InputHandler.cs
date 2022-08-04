using FlappyBird.Mechanics;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameDataContainer container;

    public void Flight()
    {
        if (container.pipeConfig.isSpawnPipe == false) return;

        container.birdConfig.birdRigidbody.velocity = Vector2.up * container.birdConfig.powerJump;
    }
}