using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class GunClass {
    private float fireRate;
    private float bullets;
    private float spread;
    private float speed;
    private int damage;
    private string description;
    


    public float GetFireRate() {
        return fireRate;
    }

    public float GetBullets() {
        return bullets;
    }

    public float GetSpread() {
        return spread;
    }

    public float GetSpeed() {
        return speed;
    }

    public string GetDescription() {
        return description;
    }

    public int GetDamage() {
        return damage;
    }


}
