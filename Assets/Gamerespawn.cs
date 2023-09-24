using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamerespawn : MonoBehaviour
{
    public float threshold;
    
    void FixedUpdate()
    {
        if (transform.position.y < threshold)
        {
            transform.position = new Vector3(100.49f, 28.82f, 0.25f);
        }
    }
}
