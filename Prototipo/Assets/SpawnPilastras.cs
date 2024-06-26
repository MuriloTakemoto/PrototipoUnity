using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class SpawnPilastras : MonoBehaviour
{
    public GameObject pilastra;
    public float height;
    public float maxTime;

    private float timer = 1f;

    void Start()
    {
        GameObject newPilastra = Instantiate(pilastra);
        newPilastra.transform.position = transform.position + new UnityEngine.Vector3(0, Random.Range(-height, height));

    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newPilastra = Instantiate(pilastra);
            newPilastra.transform.position = transform.position + new UnityEngine.Vector3(0, Random.Range(-height, height));
            Destroy (newPilastra, 20f);
            timer = 0;
        }
        timer += Time.deltaTime;    
    }
}
