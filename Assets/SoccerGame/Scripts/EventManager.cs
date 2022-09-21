using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void increaseLeftPoints();
    public static event increaseLeftPoints leftPoints;

    public static void PointsForTheLeft()
    {
        if(leftPoints != null)
        {
            leftPoints();
        }
    }

    public delegate void increaseRightPoints();
    public static event increaseRightPoints rightPoints;

    public static void PointsForTheRight()
    {
        if(rightPoints != null)
        {
            rightPoints();
        }
    }

}
