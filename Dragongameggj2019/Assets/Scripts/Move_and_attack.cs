﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_and_attack : MonoBehaviour
{
<<<<<<< HEAD
<<<<<<< HEAD
    public GameObject blood;

    public float moveSpeed = 3f;
=======
    gggameManager GameManager;
    float dirX, dirY;
    public float moveSpeed = 5f;
    public Vector3 moveVector;
>>>>>>> parent of 254fc3a... Back again
=======
    float dirX, dirY;
    public float moveSpeed = 5f;
>>>>>>> parent of df7e612... Moving script con
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
<<<<<<< HEAD
<<<<<<< HEAD
        leftWayPoint = GameObject.Find("LeftWayPoint").GetComponent<Transform>();
        rightWayPoint = GameObject.Find("RightWayPoint").GetComponent<Transform>();
=======
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        GameManager = gameController.GetComponent<gggameManager>();
>>>>>>> parent of 254fc3a... Back again
=======

>>>>>>> parent of df7e612... Moving script con
    }

    void Update()
    {
<<<<<<< HEAD
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
=======
       
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");
>>>>>>> parent of df7e612... Moving script con
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX * moveSpeed, dirY * moveSpeed);
    }
}