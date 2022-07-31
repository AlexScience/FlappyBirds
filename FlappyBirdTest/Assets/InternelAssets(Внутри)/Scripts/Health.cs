using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int health = 1;

    private void Update()
    {
        if (health>0)
        {
            return;
        }

        if (health <= 0)
        {
            var temp = GameObject.FindGameObjectWithTag("Player");
            Destroy(temp);
            Time.timeScale = 0;
        }
    }

}
