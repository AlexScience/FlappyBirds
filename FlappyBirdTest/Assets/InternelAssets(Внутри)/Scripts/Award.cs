using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Award : MonoBehaviour
{
    private DataContainer _container;

    private void Awake()
    {
        _container = FindObjectOfType<DataContainer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _container.coins++;
        }
    }
}
