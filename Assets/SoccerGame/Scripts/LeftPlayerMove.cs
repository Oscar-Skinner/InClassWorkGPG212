using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPlayerMove : MonoBehaviour
{
    private float turnSpeed = 100f;
    private float speed = 10f;

    public Rigidbody rb;

    void FixedUpdate()
    {
        if(Input.GetKey("a"))
        {
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);
        }
        if(Input.GetKey("d"))
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }

        if(Input.GetKey("w"))
        {
            transform.Translate(speed * Time.deltaTime,0f,0f);
        }
        
        if(Input.GetKey("s"))
        {
            transform.Translate(-speed * Time.deltaTime,0f,0f);
        }
    }
}
