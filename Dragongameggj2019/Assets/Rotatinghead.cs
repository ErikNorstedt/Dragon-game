using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatinghead : MonoBehaviour {

    public float speed = 5f;
    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    

    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * speed);

        //Camera and rotating stuff
        Vector3 mousepos = Input.mousePosition;
        mousepos = Camera.main.ScreenToWorldPoint(mousepos);

        Vector2 direction = new Vector2(
            mousepos.x - transform.position.x,
            mousepos.y - transform.position.y
            );

        transform.right = direction;

    }
}
