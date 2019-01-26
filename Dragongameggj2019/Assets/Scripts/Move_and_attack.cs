using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_and_attack : MonoBehaviour
{
    gggameManager GameManager;
    float dirX, dirY;
    public float moveSpeed = 5f;
    public Vector3 moveVector;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        GameManager = gameController.GetComponent<gggameManager>();
    }

    void Update()
    {
        transform.Translate(GameManager.moveVector * GameManager.moveSpeed * Time.deltaTime);
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX * moveSpeed, dirY * moveSpeed);
    }
}