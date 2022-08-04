using FlappyBird.Mechanics;
using System.Collections;
using UnityEngine;

public sealed class PipeControler : MonoBehaviour
{
    public GameDataContainer container;

    private void Awake()
    {
        if (container == null)
        {
            container = FindObjectOfType<GameDataContainer>();
        }
    }
    private void Start() => StartCoroutine(nameof(PipeSpawn));

    public IEnumerator PipeSpawn()
    {
        while (container.pipeConfig.isSpawnPipe)
        {
            yield return new WaitForSeconds(container.pipeConfig.timeSpawn);

            var rnd = Random.Range(container.pipeConfig.pipePosition.x, container.pipeConfig.pipePosition.y);
            var NewPipe = Instantiate(container.pipeConfig.pipePrefab, new Vector2(2, rnd), Quaternion.identity);

            Destroy(NewPipe, container.pipeConfig.pipeTimeLife);



        }
    }
}