using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;
    //use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if player has passed the position do next
        if(player.position.y > transform.position.y)
        {
            //follow
            transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
        }
    }
}
