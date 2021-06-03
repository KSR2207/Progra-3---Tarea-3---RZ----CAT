using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float jumpspeed = 3.0f;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            rb.velocity = new Vector2(-jumpspeed, 0.0f);
        }

        else if (Input.GetKey("right"))
        {
            rb.velocity = new Vector2(jumpspeed, 0.0f);
        }
        else
        {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }
    }
}
