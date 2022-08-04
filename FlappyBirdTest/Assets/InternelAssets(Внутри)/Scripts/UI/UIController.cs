using FlappyBird.Mechanics;
using UnityEngine;

public sealed class UIController : MonoBehaviour
{
    private GameDataContainer container;

    private void Awake()
    {
        if (container == null)
            container = FindObjectOfType<GameDataContainer>();
    }

    private void Update() => container.UIConfig.scoreText.text = container.gameCurrence.coins.ToString();
}