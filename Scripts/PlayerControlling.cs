using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlling : MonoBehaviour
{
    bool canJump;

    Animator animator;

    Rigidbody2D rb;
    [SerializeField] float jumpForce;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        canJump = true;
    }
    

  
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&canJump)
        {
            Jump(); 
        }
    }


    void Jump()
    {
       
        rb.velocity = Vector2.up * jumpForce;
        animator.SetTrigger("Jump");
        GameManager.instance.IncrementScore();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.CompareTag("Ground")){
            canJump = true;
           
        }
     
       
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
      if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = false;
           
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(collision.gameObject);
            animator.Play("sDead");
            GameManager.instance.GameOver();
            GameManager.instance.StopScroll();
        }
    }
}
