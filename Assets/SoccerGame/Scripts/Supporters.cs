using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Supporters : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.LeftScoresPoints += LeftCheer;
        EventManager.RightScoresPoints += RightCheer;
    }
    private void OnDisable()
    {
        EventManager.LeftScoresPoints -= LeftCheer;
        EventManager.RightScoresPoints -= RightCheer;
    }

    private void FixedUpdate()
    {
        //make the characters idle jump based on a random range
    }

    void IdleJump()
    {
        this.GetComponent<Rigidbody>().velocity = new Vector3(0, 2, 0);
    }
    public void LeftCheer()
    {
        this.GetComponent<Rigidbody>().velocity = new Vector3(0, Random.Range(0f,6f), 0);
    }
    public void RightCheer()
    {
        this.GetComponent<Rigidbody>().velocity = new Vector3(0, Random.Range(0f,6f), 0);
    }
}
