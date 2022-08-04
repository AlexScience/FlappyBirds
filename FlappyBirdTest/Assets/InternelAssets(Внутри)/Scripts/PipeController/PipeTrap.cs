using FlappyBird.Mechanics;
using UnityEngine;

public sealed class PipeTrap : MonoBehaviour, IDamagable
{
    private GameDataContainer container;

    private void Awake()
    {
        if (container == null)
            container = FindObjectOfType<GameDataContainer>();
    }

    public void Damage()
    {
        //var player =
        GameObject.FindGameObjectWithTag("Player").GetComponent<Health>().health -= 1;


        // => container.birdConfig.birdPrefab.GetComponent<Health>().health -= 1;
    }
}