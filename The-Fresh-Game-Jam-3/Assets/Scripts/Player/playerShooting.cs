using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
float ammoCount;
float ammo;
Gun shotgun;


[SerializeField]
GameObject bullet;
[SerializeField]
Transform firePoint;
    void Start()
    {
    shotgun = GunContainer.shotgun;
    ammoCount = shotgun.GetBullets();
    ammo = ammoCount;
    }

    void Update()
    {
    if (Input.GetButtonDown("Fire1") && ammo != 0)
    {
    Instantiate(bullet, firePoint.position, firePoint.rotation);
    ammo--;
    }
    if (Input.GetKeyDown("r"))
    {
    Invoke("Reload", shotgun.GetSpeed());
    }

    }


    void Reload()
    {
    ammo = ammoCount;
    }
}
