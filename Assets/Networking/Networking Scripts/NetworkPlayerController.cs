using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkPlayerController : MonoBehaviour
{
    public NetworkPlayerView view;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            view.total += 1;
            Debug.Log(view.total);
        }
    }
}
