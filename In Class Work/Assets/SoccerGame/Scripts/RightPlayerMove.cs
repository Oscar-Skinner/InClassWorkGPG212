using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPlayerMove : MonoBehaviour
{
    private float turnSpeed = 100f;
    private float speed = 10f;

    public Rigidbody rb;

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(speed * Time.deltaTime,0f,0f);
        }
        
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-speed * Time.deltaTime,0f,0f);
        }
    }
}
