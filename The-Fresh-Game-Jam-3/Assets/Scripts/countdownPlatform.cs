using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countdownPlatform : MonoBehaviour
{
[SerializeField]
float countdownDefault = 10f;
[SerializeField]
Sprite spikePlatform;
[SerializeField]
Sprite normalPlatform;



float countdown;


    // Start is called before the first frame update
    void Start()
    {
    countdown = countdownDefault;
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
    void SwitchPlatform()
    {
    SpriteRenderer renderer = GetComponent<SpriteRenderer>();
    if (renderer.sprite == normalPlatform)
    {
    renderer.sprite = spikePlatform;
    } else {
    renderer.sprite = normalPlatform;
    }
    
    
    }



    }
}
