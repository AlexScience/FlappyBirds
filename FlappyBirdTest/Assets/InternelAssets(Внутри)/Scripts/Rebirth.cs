using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebirth : MonoBehaviour
{
    private DataContainer container;
    public GameObject BirdTest;
    public Vector2 birdPos;
    private bool isRestart = true;
    public GameObject Tybe;

    private void Awake()
    {
        if (container == null)
        {
            container = FindObjectOfType<DataContainer>();
        }
    }

    private void Update()
    {

        if (container.bird == null)
        {
            RestartBird();
        }
    }

    private void RestartBird()
    {
        if (isRestart == true)
        {
            var pipe = GameObject.FindGameObjectsWithTag("Tybe");
            foreach (var i in pipe)
            {
                Destroy(i);
            }
            Instantiate(BirdTest, birdPos, Quaternion.identity);
            container.bird = BirdTest;
            container.pipe = Tybe;
            isRestart = false;
        }


    }
}
