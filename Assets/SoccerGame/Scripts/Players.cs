using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public Vector2 MoveDirection;
    
    private float playerSpeed = 1500f;

    private void FixedUpdate()
    {
        Vector3 finalMove = new Vector3(MoveDirection.x, 0, MoveDirection.y);
        this.GetComponent<Rigidbody>().AddRelativeForce(finalMove * playerSpeed);
    }
}
