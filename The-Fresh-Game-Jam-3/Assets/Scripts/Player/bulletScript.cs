using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
SpriteRenderer renderer;
PlayerController2D controller;
Rigidbody2D rb2d;
Vector3 speed;

    // Start is called before the first frame update
    void Start()
    {
    speed = new Vector2(Vector3.right.x + 10, 0);
    controller = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController2D>();
    renderer = GetComponent<SpriteRenderer>();
    rb2d = GetComponent<Rigidbody2D>();
    if (controller.isFacingRight == true)
    {
    rb2d.AddForce(speed, ForceMode2D.Impulse);
    renderer.flipX = false;
    } else {
    rb2d.AddForce(-speed, ForceMode2D.Impulse);
    renderer.flipX = true;
    }
    Destroy(gameObject, 10f);
    
    }

    // Update is called once per frame
    void Update()
    {
    

    }
}
