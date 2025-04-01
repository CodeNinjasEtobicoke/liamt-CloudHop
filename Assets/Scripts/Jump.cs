using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    private Rigidbody2D rb;
    private float jumpForce = 15;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("Jump") && (rb.velocity.y < 0.1f && rb.velocity.y > -0.1f))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        }
    }
}
