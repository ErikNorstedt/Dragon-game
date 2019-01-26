using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_and_attack : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject blood;

    public float moveSpeed = 3f;
=======
    gggameManager GameManager;
    float dirX, dirY;
    public float moveSpeed = 5f;
    public Vector3 moveVector;
>>>>>>> parent of 254fc3a... Back again
    Rigidbody2D rb;
    Vector3 localScale;
    bool movingRight = true;
    Transform leftWayPoint, rightWayPoint;

    void Start()
    {
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
<<<<<<< HEAD
        leftWayPoint = GameObject.Find("LeftWayPoint").GetComponent<Transform>();
        rightWayPoint = GameObject.Find("RightWayPoint").GetComponent<Transform>();
=======
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        GameManager = gameController.GetComponent<gggameManager>();
>>>>>>> parent of 254fc3a... Back again
    }

    void Update()
    {
<<<<<<< HEAD
        if (transform.position.x > rightWayPoint.position.x)
            movingRight = false;
        if (transform.position.x < leftWayPoint.position.x)
            movingRight = true;

        if (movingRight)
            moveRight();
        else
            moveLeft();
=======
        transform.Translate(GameManager.moveVector * GameManager.moveSpeed * Time.deltaTime);
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");
>>>>>>> parent of 254fc3a... Back again
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