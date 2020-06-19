using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
float ammoCount;
float ammo;
public Gun currentGun;
float spread;
Quaternion rotation;
Quaternion dir;

[SerializeField]
GameObject bullet;
[SerializeField]
Transform firePoint;
float fireRate;
float timeToNextFire;
bool canFire = true;

    void Start()
    {
    currentGun = GunContainer.deagle;
    ammoCount = currentGun.GetBullets();
    ammo = ammoCount;
    spread = currentGun.GetSpread();
    rotation = Quaternion.EulerAngles(0, 0, Random.Range(-spread, spread)); 
    dir = firePoint.rotation * rotation;
    }


    void Update()
    {
    if (Input.GetButtonDown("Fire1") && ammo != 0 && canFire)
    {
    canFire = false;
    for (int i = 0; i < currentGun.GetFire(); i++)
    {
    Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
    ammo--;
    Invoke("ResetFire", fireRate);
    
    
    
    }
    if (Input.GetKeyDown("r"))
    {
    Invoke("Reload", currentGun.GetReloadSpeed());
    }

    }


    void Reload()
    {
    ammo = ammoCount;
    }
    void ResetFire()
    {
    canFire = true;
    }
    
    public float getAmmoLeft() {
    return ammo;
    }


}
