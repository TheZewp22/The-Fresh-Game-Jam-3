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
    private string description;
    
    public Gun(float fireRate, float bullets, float spread, float reloadspeed, int damage, string desc) {
        this.fireRate = fireRate;
        this.bullets = bullets;
        this.spread = spread;
        this.reloadspeed = reloadspeed;
        this.description = desc;
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

    public string GetDescription() {
        return description;
    }

    public int GetDamage() {
        return damage;
    }


}
