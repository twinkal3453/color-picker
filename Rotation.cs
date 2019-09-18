using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationspeed;
   //use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float randomNumber = Random.Range(-150, 100);
            
        transform.Rotate(0f, 0f, rotationspeed * Time.deltaTime);
    }
}