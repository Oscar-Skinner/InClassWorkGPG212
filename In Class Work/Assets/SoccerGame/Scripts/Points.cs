using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    public TMP_Text leftDisplayedPoints;
    public TMP_Text rightDisplayedPoints;
    private string left;
    private string right;
    private float leftPointTotal = 0;
    private float rightPointTotal = 0;

    void OnEnable()
    {
        EventManager.leftPoints += leftGetsPoints;
        EventManager.rightPoints += RightGetsPoints;
    }
    void OnDisable()
    {
        EventManager.leftPoints -= leftGetsPoints;
        EventManager.rightPoints -= RightGetsPoints;
    }

    void Start()
    {
        leftDisplayedPoints.text = "Left Team Score: " + leftPointTotal;
        rightDisplayedPoints.text = "Right Team Score: " + rightPointTotal;
    }

    void leftGetsPoints()
    {
        leftPointTotal ++;
        leftDisplayedPoints.text = "Left Team Score: " + leftPointTotal;
    }
    void RightGetsPoints()
    {
        rightPointTotal ++;
        rightDisplayedPoints.text = "Left Team Score: " + rightPointTotal;
    }

}
