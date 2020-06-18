using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
Rigidbody2D rb2d;
[SerializeField]
int extraJumpsValue = 2;
[SerializeField]
float moveSpeed = 10f;
[SerializeField]
float jumpForce = 10f;
[SerializeField]
float checkRadius = 5f;
[SerializeField]
Transform groundCheckPos;
[SerializeField]
LayerMask whatIsGround;
float movementX = 0f;
int extraJumps;
bool isGrounded = false;


    // Start is called before the first frame update
    void Start()
    {
    extraJumps = extraJumpsValue;
    rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    isGrounded = Physics2D.OverlapCircle(groundCheckPos.position, checkRadius, whatIsGround);
    if (isGrounded)
    {
    extraJumps = extraJumpsValue;
    }
    
    movementX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
    if (Input.GetKeyDown("space") && extraJumps > 0)
    {
    Jump();
    }    
    }
    void FixedUpdate()
    {
    rb2d.velocity = new Vector2(movementX, rb2d.velocity.y);
    }
    void Jump()
    {
    Debug.Log(rb2d);
    if (isGrounded)
    {
    rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
    } else {
    rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
    extraJumps--;
    }
    }







}
