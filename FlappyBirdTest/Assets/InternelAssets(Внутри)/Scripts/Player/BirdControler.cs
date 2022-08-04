using FlappyBird.Mechanics;
using UnityEngine;

public sealed class BirdControler : MonoBehaviour
{
    private GameDataContainer container;
    private InputHandler inputHandler;

    private void Awake()
    {
        if (container == null)
            container = FindObjectOfType<GameDataContainer>();

        if (inputHandler == null)
            inputHandler = FindObjectOfType<InputHandler>();
    }

    private void Update()
    {
 
        if (Input.GetMouseButtonDown(0))
        {
            inputHandler.Flight();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<IDamagable>() != null)
            collision.gameObject.GetComponent<IDamagable>().Damage();
    }
}