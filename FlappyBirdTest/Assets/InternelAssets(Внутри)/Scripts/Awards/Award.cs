using FlappyBird.Mechanics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Award : MonoBehaviour
{
    private GameDataContainer _container;

    private void Awake()
    {
        _container = FindObjectOfType<GameDataContainer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _container.gameCurrence.coins++;
        }
    }
}
