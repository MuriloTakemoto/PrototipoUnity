using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilastras : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
