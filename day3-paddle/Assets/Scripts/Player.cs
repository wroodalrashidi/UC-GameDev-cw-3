
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D playerRb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
       playerRb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        playerRb.velocity = new Vector2(Input.GetAxis("Horizontal")* speed,0f) ;
        
    }
}
