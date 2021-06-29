using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class döndürme : MonoBehaviour
{

    public float donmehizi = 0f;

    void Update()
    {
        transform.Rotate(0, donmehizi, 0); 
    }
    
}
