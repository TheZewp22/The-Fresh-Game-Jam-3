using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
Rigidbody2D rb2d;
Vector3 speed;

    // Start is called before the first frame update
    void Start()
    {
    speed = new Vector2(Vector3.right.x + 10, 0);
    rb2d = GetComponent<Rigidbody2D>();
    rb2d.AddForce(speed, ForceMode2D.Impulse);
    
    }

    // Update is called once per frame
    void Update()
    {
    

    }
}
