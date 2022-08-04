using FlappyBird.Mechanics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPopup : MonoBehaviour
{
    public GameDataContainer container;

    private void Awake()
    {
        if (container == null)
        {
            container = FindObjectOfType<GameDataContainer>();
        }
    }

    private void Update()
    {
        if (container.pipeConfig.isSpawnPipe == false)
        {
            container.UIConfig.panel.SetActive(true);
            container.UIConfig.score.text = $"Score: {container.gameCurrence.coins}" ;
                
        }
    }

}
