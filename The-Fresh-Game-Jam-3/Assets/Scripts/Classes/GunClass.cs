using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[System.Serializable]
public class Gun {
    private float fireRate;
    private float bullets;
    private float spread;
    private float reloadspeed;
    private int damage;
    private int bulletstofire;
    
    public Gun(float fireRate, float bullets, float spread, float reloadspeed, int damage, int bulletstofire) {
        this.fireRate = fireRate;
        this.bullets = bullets;
        this.spread = spread;
        this.reloadspeed = reloadspeed;
        this.bulletstofire = bulletstofire;
        this.damage = damage;
    }

    public float GetFireRate() {
        return fireRate;
    }

    public float GetBullets() {
        return bullets;
    }

    public float GetSpread() {
        return spread;
    }

    public float GetReloadSpeed() {
        return reloadspeed;
    }

    public float GetFire() {
        return bulletstofire;
    }

    public int GetDamage() {
        return damage;
    }


}
