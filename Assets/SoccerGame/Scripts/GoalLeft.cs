using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalLeft : MonoBehaviour
{
    //when ball collides, add a point
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<SoccerBall>() != null)
        {
            print("Right Scored");
            EventManager.PointsForTheRight();
        }
    }
}
