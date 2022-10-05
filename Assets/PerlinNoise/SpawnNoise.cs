using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNoise : MonoBehaviour
{
    public GameObject Prefab;
    
    public int Width = 20;
    public int height = 20;
    // Start is called before the first frame update
    void Start()
    {
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                Mathf.PerlinNoise(x, 0);
                Instantiate(Prefab, new Vector3(x, 0, 0), Quaternion.identity);
            }
        }
        
    }
}
