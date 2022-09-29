using UnityEngine;

public enum Teams
{
    Left,
    Right
}
public class Goal : MonoBehaviour
{
    public Teams myTeam;
    
    public delegate void GoalSignature(Goal goal);
    public event GoalSignature GoalEvent;
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<SoccerBall>() != null)
        {
            GoalEvent?.Invoke(this);
        }
    }
}
