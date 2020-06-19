using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GunContainer
{
public static readonly Gun pistol = new Gun(1f, 9, 5, 1f, 3, 1);
public static readonly Gun shotgun = new Gun(6f, 10f, 30f, 5f, 6, 3);
public static readonly Gun deagle = new Gun(3f, 7f, 2f, 2f, 100, 1);
}