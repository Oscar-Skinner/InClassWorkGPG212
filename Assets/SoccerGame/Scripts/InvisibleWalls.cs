using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleWalls : MonoBehaviour
{
    public delegate void CommentatorsBox();
    public static event CommentatorsBox OutOfBounds;
    
    public void OnCollisionEnter(Collision collision)
    {
        //if the ball collides then print Right point
        if(collision.gameObject.GetComponent<SoccerBall>() != null)
        {
            OutOfBounds?.Invoke();
        }
    }
}
