using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControler : MonoBehaviour
{
    public DataContainer container;
    public InputHandler inputHandler;
    private void Awake()
    {
        if (container ==null)
        {
            container = FindObjectOfType<DataContainer>();
        }
        if (inputHandler == null)
        {
            inputHandler = FindObjectOfType<InputHandler>();
        }
    }
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            inputHandler.Flight();


        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<IDamagable>() != null)
        {
            
            collision.gameObject.GetComponent<IDamagable>().Damage();

        }
    }
}
