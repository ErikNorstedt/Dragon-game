using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_and_attack : MonoBehaviour
{
    public GameObject blood;

    public float moveSpeed = 3f;
    Rigidbody2D rb;
    Vector3 localScale;
    bool movingRight = true;
    Transform leftWayPoint, rightWayPoint;

    void Start()
    {
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        leftWayPoint = GameObject.Find("LeftWayPoint").GetComponent<Transform>();
        rightWayPoint = GameObject.Find("RightWayPoint").GetComponent<Transform>();
    }

    void Update()
    {
        if (transform.position.x > rightWayPoint.position.x)
            movingRight = false;
        if (transform.position.x < leftWayPoint.position.x)
            movingRight = true;

        if (movingRight)
            moveRight();
        else
            moveLeft();
    }

    void moveRight()
    {
        movingRight = false;
        localScale.x = 1;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * moveSpeed, rb.velocity.y);
    }
    void moveLeft()
    {
        movingRight = false;
        localScale.x = -1;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * moveSpeed, rb.velocity.y);
    }
}