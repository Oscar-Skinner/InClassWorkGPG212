using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNoise : MonoBehaviour
{
    public GameObject Prefab;

    private int amount = 200;

    public float scale = 40;
    public float zoom;
    
    private float x;
    private float y;
    private Vector3 prefabPosition;
    private void Start()
    {
        for (int positionX = 0; positionX < amount; positionX++)
        {
            for (int positionZ = 0; positionZ < amount; positionZ++)
            {
                prefabPosition.x = positionX;
                prefabPosition.y = Mathf.PerlinNoise((positionX * zoom), (positionZ * zoom)) * scale;
                prefabPosition.z = positionZ;
                Instantiate(Prefab, prefabPosition, Quaternion.identity);
            }
        }
        
    }

}
