using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public DataContainer container;
    private Rigidbody2D rb;

    private void Awake() => rb = container.bird.GetComponent<Rigidbody2D>();

    public void Flight() => rb.velocity = Vector2.up * container.powerJump;
}

