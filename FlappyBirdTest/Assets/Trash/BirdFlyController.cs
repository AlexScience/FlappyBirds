using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlyController : MonoBehaviour
{
    public float power;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * power;
        }
    }
}
