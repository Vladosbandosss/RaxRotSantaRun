using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.left * speed;
    }
    private void Update()
    {
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}
