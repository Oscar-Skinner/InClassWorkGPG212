using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Supporters : MonoBehaviour
{
    private void OnEnable()
    {
        GameManager.CheerAndCleanUp += Cheer;
    }
    private void OnDisable()
    {
        GameManager.CheerAndCleanUp -= Cheer;
    }

    public void Cheer()
    {
        this.GetComponent<Rigidbody>().velocity = new Vector3(0, Random.Range(0f,6f), 0);
    }
}
