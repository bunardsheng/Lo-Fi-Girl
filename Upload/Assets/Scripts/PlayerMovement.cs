using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    public float playerSpeed = 0;
    private Rigidbody2D rb;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity += Vector2.up * playerSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity += Vector2.down * playerSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity += Vector2.right * playerSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity += Vector2.left * playerSpeed;
        }

        rb.velocity = rb.velocity.normalized * playerSpeed;
        anim.SetFloat("moveX", rb.velocity.x);
        anim.SetFloat("moveY", rb.velocity.y);

        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            if (Input.GetAxisRaw("Horizontal") != 0)
            {
                anim.SetFloat(("lastMoveX"), Input.GetAxisRaw("Horizontal"));
            }

            anim.SetFloat(("lastMoveY"), Input.GetAxisRaw("Vertical"));

        }
    }
}
