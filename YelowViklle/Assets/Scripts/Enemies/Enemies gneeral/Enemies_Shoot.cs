using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies_Shoot : EnemiesDamage
{
    public Transform firePoint;
    float fireForce = 15f;
    public GameObject BulletPrefab;
    public float firerate = 2, NextfireTime = 0;

    protected override void Update()
    {
        base.Update();
        if (IsInChaseRange)
        {
            if (Canfire())
            {
                // Shoot();
                //Aca usar Factory y object pool

            }
        }
       
    }

    public void Shoot()
    {
        //Aca usar Factory y object pool
        GameObject bullet = Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        rb.AddForce(firePoint.up * fireForce, ForceMode.Impulse);
        NextfireTime = Time.time + 1f / firerate;
    }

    bool Canfire()
    {

        return Time.time >= NextfireTime;
    }

}
