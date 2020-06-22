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
[SerializeField]
GameObject lightObject;
Light light;

bool isOn = true;



float countdown;


    // Start is called before the first frame update
    void Start()
    {
    countdown = countdownDefault;
    renderer = GetComponent<SpriteRenderer>();
    collider2D = GetComponent<BoxCollider2D>();
    light = lightObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
    if (countdown <= 0)
    {
    SwitchPlatform();
    countdown = countdownDefault;

    } else {
    countdown -= Time.deltaTime;

    }
    }
    void SwitchPlatform()
    {
    if (isOn == true) {
    collider2D.enabled = false;
    renderer.color = (red);
    light.color = (red);
    isOn = false;
    } else {
    light.color = (normal);
    collider2D.enabled = true;
    renderer.color = (normal);
    isOn = true;
    }

    }
}
