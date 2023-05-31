using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class ChangeColour : NetworkBehaviour
{
    public NetworkVariable<Vector4> ColorValue  = new NetworkVariable<Vector4>();

    /*
    public override void OnNetworkSpawn()
    {
        if (IsOwner)
        {
            ChangeColor();
        }
    }

    public void ChangeColor()
    {
        if (NetworkManager.Singleton.IsServer)
        {
            Vector4 randomColour = GetRandomMaterialIndex();
            SetColor(randomColour);
        }
        else
        {
            SubmitMaterialIndexRequestServerRpc();
        }
    }

    [ServerRpc]
    void SubmitMaterialIndexRequestServerRpc(ServerRpcParams rpcParams = default)
    {
        int randomIndex = GetRandomMaterialIndex();
        setMaterialIndex(randomIndex);
    }

    void SetColor(Vector4 color)
    {
        ColorValue .Value = index;
        // Apply the material change to the object
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null && renderer.sharedMaterials.Length > index)
        {
            Material newMaterial = renderer.sharedMaterials[index];
            renderer.material = newMaterial;
        }
    }
    
    static int GetRandomMaterialIndex()
    {
        return Random.Range(0, 3);
    }

    void Update()
    {
        SetColor(ColorValue .Value);
    }*/
}
