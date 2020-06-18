using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
float ammoCount;
float ammo;
Gun pistol;


[SerializeField]
GameObject bullet;
[SerializeField]
Transform firePoint;
    void Start()
    {
    pistol = GunContainer.pistol;
    ammoCount = pistol.GetBullets();
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
    Invoke("Reload", pistol.GetReloadSpeed());
    }

    }


    void Reload()
    {
    ammo = ammoCount;
    }
}
