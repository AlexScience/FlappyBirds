using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlorTrap : MonoBehaviour, IDamagable
{
    private DataContainer container;

    public void Awake()
    {
        if (container == null)
        {
            container = FindObjectOfType<DataContainer>();
        }
    }

    public void Damage()
    {
        container.bird.transform.localScale = new Vector2(5, 5);
        container.bird.GetComponent<SpriteRenderer>().color = Color.red;
        
        
    }
}
