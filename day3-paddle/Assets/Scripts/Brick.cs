using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brick : MonoBehaviour
{
    
     public float delta = 1.5f;  
     public float speed = 2.0f; 
     private Vector3 startPos;
 
    //  void OnTriggerEnter2D (Collision2D coin)
    //  {
    //     BrickCounter.brickCounter += 1;
    //     Destroy(gameObject);
    //  }
     
     void Start () {
         startPos = transform.position;
     }
     
     void Update () {
         Vector3 v = startPos;
         v.x += delta * Mathf.Sin (Time.time * speed);
         transform.position = v;
     }

    private void OnCollisionEnter2D (Collision2D other)
    {
       BrickCounter.brickCounter += 1;
        Destroy(gameObject);
    }
} 
