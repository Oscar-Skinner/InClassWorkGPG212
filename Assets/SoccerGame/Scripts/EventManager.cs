using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void Scores();
    public static event Scores LeftScoresPoints;
    public static event Scores RightScoresPoints;

    public static void PointsForTheLeft()
    {
        LeftScoresPoints?.Invoke();
    }
    public static void PointsForTheRight()
    {
        RightScoresPoints?.Invoke();
    }
}
