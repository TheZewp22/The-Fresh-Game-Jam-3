using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
SpriteRenderer renderer;
PlayerController2D controller;
Rigidbody2D rb2d;
Vector3 speed;

float spread;
    // Start is called before the first frame update
    void Start()
    {
    controller = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController2D>();
    spread = controller.GetComponent<playerShooting>().currentGun.GetSpread();
   renderer = GetComponent<SpriteRenderer>();
   speed = new Vector3(500, 0, 0);
    rb2d = GetComponent<Rigidbody2D>();
    if (controller.isFacingRight == true)
    {
    rb2d.AddForce(Vector3.right.x * speed);
    renderer.flipX = false;
    } else {
    rb2d.AddForce(-Vector3.right.x * speed);
    renderer.flipX = true;
    }
    Destroy(gameObject, 10f);
    
    }

    // Update is called once per frame
    void Update()
    {
    

    }
}
