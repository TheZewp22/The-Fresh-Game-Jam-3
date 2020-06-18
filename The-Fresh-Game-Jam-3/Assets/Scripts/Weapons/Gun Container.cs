using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunContainer : MonoBehaviour
{
[SerializeField]
Sprite shotgunicon;
public static readonly Gun shotghun = new Gun(3f, 9, 5, 5f, 3, "Shotgun");
void Start()
{
}

}