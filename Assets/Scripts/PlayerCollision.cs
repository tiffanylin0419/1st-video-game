using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playerMovement movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag=="Obstacle"){
            movement.enabled=false;
            FindObjectOfType<GameManager>().EndGame();

        }

    }

}