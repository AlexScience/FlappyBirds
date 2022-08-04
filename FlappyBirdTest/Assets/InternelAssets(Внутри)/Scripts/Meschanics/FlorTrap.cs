using FlappyBird.Mechanics;
using UnityEngine;

public sealed class FlorTrap : MonoBehaviour, IDamagable
{
    private GameDataContainer container;

    public void Awake()
    {
        if (container == null)
            container = FindObjectOfType<GameDataContainer>();
    }

    public void Damage()
    {
        //container.birdConfig.birdPrefab.transform.localScale = new Vector2(5, 5);
        //container.birdConfig.birdPrefab.GetComponent<SpriteRenderer>().color = Color.red;
    }
}