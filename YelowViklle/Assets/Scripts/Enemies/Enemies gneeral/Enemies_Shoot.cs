using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies_Shoot : EnemiesDamage
{
    //public Transform firePoint;
    float fireForce = 15f;
    public float NextfireTime = 0;


    public GameObject[] Firepoint;
    public int whereshoot;

    protected override void Update()
    {
        base.Update();
        if (IsInChaseRange)
        {
            if (Canfire())
            {
                 Shoot();
                //Aca usar Factory y object pool

            }
        }
       
    }

    public void Shoot()
    {
        //Aca usar Factory y object pool
        //GameObject bullet = Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);

        // Rigidbody rb = bullet.GetComponent<Rigidbody>();

        // rb.AddForce(firePoint.up * fireForce, ForceMode.Impulse);
        var bullet = BuletManager.instance.GetBullet();
        bullet.transform.position = Firepoint[whereshoot].transform.position;
        bullet.transform.forward = Firepoint[whereshoot].transform.forward;

        NextfireTime = Time.time + 1f / FlyweightPointer.EnemiesShooters.FireRate;
    }

    bool Canfire()
    {

        return Time.time >= NextfireTime;
    }

}
