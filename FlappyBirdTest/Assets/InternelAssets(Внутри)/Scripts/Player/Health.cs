using UnityEngine;
using FlappyBird.Mechanics;

public sealed class Health : MonoBehaviour
{

    public int health = 1;
    private GameDataContainer container;
 

    private void Awake()
    {
        if (container == null)
        {
            container = FindObjectOfType<GameDataContainer>();
        }
    }

    private void Update()
    {
        if (health > 0)
        {
            return;
        }

        if (health <= 0)
        {
            
                var bird = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
                bird.AddForce(Vector2.down * 5);
                container.pipeConfig.isSpawnPipe = false;
                var pipes = GameObject.FindGameObjectsWithTag("Tybe");
                for (int i = 0; i < pipes.Length; i++)
                {
                    Destroy(pipes[i], 0.5f);
                }
                Destroy(bird, 0.5f);

          


            
        }
    }
}