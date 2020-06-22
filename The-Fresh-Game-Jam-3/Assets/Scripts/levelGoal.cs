using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGoal : MonoBehaviour
{
gameManager manager;


void Start()
{
manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<gameManager>();
}

void OnTriggerEnter2D(Collider2D collider)
{
manager.WinLevel();
}
}
