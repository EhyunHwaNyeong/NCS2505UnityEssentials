using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotationSpeed = 0;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }
}
