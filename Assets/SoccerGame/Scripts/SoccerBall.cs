using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{
    public delegate void ScoredGoal();
    public static event ScoredGoal GoalEvent;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<GoalLeft>() != null)
        {
            Destroy(this.gameObject);
            GoalEvent?.Invoke();
        }
        if (collision.gameObject.GetComponent<GoalRight>() != null)
        {
            Destroy(this.gameObject);
            GoalEvent?.Invoke();
        }
    }
}
