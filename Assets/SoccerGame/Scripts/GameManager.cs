using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Goal[] goals;
    public int LeftPoints = 0;
    public int RightPoints = 0;
    private void OnEnable()
    {
        foreach (Goal item in goals)
        {
            item.GoalEvent += GoalOnGoalEvent;
        }
    }
    
    public delegate void TeamScored(int Left, int Right);
    public static event TeamScored TeamThatScored;

    public delegate void CelebrateGoal();

    public static event CelebrateGoal CheerAndCleanUp;
    private void GoalOnGoalEvent(Goal goalCheck)
    {
        CheerAndCleanUp?.Invoke();

        if (goalCheck.myTeam == Teams.Left)
        {
            RightPoints++;
            TeamThatScored?.Invoke(LeftPoints, RightPoints);
        }
        
        if (goalCheck.myTeam == Teams.Right)
        {
            LeftPoints++;
            TeamThatScored?.Invoke(LeftPoints, RightPoints);
        }
    }
}
