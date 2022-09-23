using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void LeftScores();
    public static event LeftScores LeftScoresPoints;

    public static void PointsForTheLeft()
    {
        LeftScoresPoints?.Invoke();
    }

    public delegate void RightScores();
    public static event RightScores RightScoresPoints;

    public static void PointsForTheRight()
    {
        RightScoresPoints?.Invoke();
    }
}
