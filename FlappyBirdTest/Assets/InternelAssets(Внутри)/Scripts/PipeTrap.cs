using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTrap : MonoBehaviour, IDamagable
{
    public DataContainer container;
    private void Awake()
    {
        if (container == null)
        {
            container = FindObjectOfType<DataContainer>();
        }
    }
    public void Damage()
    {
        container.bird.GetComponent<Health>().health -= 1;
    }
   

}
