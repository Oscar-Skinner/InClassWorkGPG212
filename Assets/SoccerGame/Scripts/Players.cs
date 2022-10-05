using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public Vector2 MoveDirection;
    public Rigidbody playerRigidbody;
    public float playerSpeed = 1500f;

    private void Start()
    {
        playerRigidbody = this.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 finalMove = new Vector3(MoveDirection.x, 0, MoveDirection.y);
        playerRigidbody.AddRelativeForce(finalMove * playerSpeed * Time.deltaTime);
    }
}
