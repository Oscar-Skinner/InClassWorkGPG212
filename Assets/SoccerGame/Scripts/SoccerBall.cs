using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{
    public Material leftTeam;
    public Material rightTeam;
    public delegate void ScoredGoal();
    public static event ScoredGoal GoalLeftEvent;
    public static event ScoredGoal GoalRightEvent;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<GoalLeft>() != null)
        {
            Destroy(this.gameObject);
            GoalRightEvent?.Invoke();
        }
        if (collision.gameObject.GetComponent<GoalRight>() != null)
        {
            Destroy(this.gameObject);
            GoalLeftEvent?.Invoke();
        }
    }
}