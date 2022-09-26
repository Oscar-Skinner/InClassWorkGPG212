using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    private Rigidbody rbRightPlayer;
    private Rigidbody rbLeftPlayer;

    public GameObject playerLeft;
    public GameObject playerRight;

    public Vector3 leftMovement;
    public Vector3 rightMovement;

    private float playerSpeed = 500f;
    
    void Start()
    {
        //Finds RigidBodys for players
        rbRightPlayer = playerRight.GetComponent<Rigidbody>();
        rbLeftPlayer = playerLeft.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        leftMovement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        rightMovement = new Vector3(Input.GetAxis("Horizontal1"), 0, Input.GetAxis("Vertical1")).normalized;
    }
    void FixedUpdate()
    {
        moveLeftCharacter(leftMovement);
        moveRightCharacter(rightMovement);
    }
    
    void moveLeftCharacter(Vector3 direction)
    {
        rbLeftPlayer.velocity = direction * playerSpeed * Time.deltaTime;
    }
    void moveRightCharacter(Vector3 direction)
    {
        rbRightPlayer.velocity = direction * playerSpeed * Time.deltaTime;
    }
}
