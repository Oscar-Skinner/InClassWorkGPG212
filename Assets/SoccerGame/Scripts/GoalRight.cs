using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalRight : MonoBehaviour
{
    //when ball collides, add a point
    
    void OnCollisionEnter(Collision collision)
    {
        //if the ball collides then print Right point
        if(collision.gameObject.GetComponent<SoccerBall>() != null)
        {
            
        }
    }
}
