using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countdownPlatform : MonoBehaviour
{
BoxCollider2D collider2D;
SpriteRenderer renderer;
[SerializeField]
float countdownDefault = 10f;
[SerializeField]
Color red;
[SerializeField]
Color normal;
bool isOn = true;



float countdown;


    // Start is called before the first frame update
    void Start()
    {
    countdown = countdownDefault;
    renderer = GetComponent<SpriteRenderer>();
    collider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
    if (countdown <= 0)
    {
    SwitchPlatform();
    countdown = countdownDefault;
    Debug.Log("Switching!");
    } else {
    countdown -= Time.deltaTime;
    Debug.Log("Time to change: " + countdown);
    }
    }
    void SwitchPlatform()
    {
    if (isOn == true) {
    collider2D.enabled = false;
    renderer.color = (red);
    isOn = false;
    } else {
    collider2D.enabled = true;
    renderer.color = (normal);
    isOn = true;
    }

    }
}
