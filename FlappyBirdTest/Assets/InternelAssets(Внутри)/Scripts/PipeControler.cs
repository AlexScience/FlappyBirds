using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeControler : MonoBehaviour
{
    public DataContainer container;
    public float x = -1, y = 4;
    public float timeLife = 10;

    private void Start()
    {
        StartCoroutine(nameof(PipeSpawn));
    }

    private IEnumerator PipeSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(container.timeSpawnPipe);
            var rnd = Random.Range(x, y);
            var NewPipe = Instantiate(container.pipe, new Vector2(2, rnd), Quaternion.identity);
            Destroy(NewPipe, timeLife);

        }

    }

}
