using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
   private DataContainer container;
    private void Awake()
    {
        if (container == null)
        {
            container = FindObjectOfType<DataContainer>();  
        }
    }

    private void Update()
    {
        container.scoreText.text = container.coins.ToString();
    }
}
