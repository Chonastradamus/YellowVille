using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies_Shoot : EnemiesDamage
{
    //public Transform firePoint;
    float fireForce = 15f;
    public float NextfireTime = 0;

    [Header("Factory_Objetcpool")]
    [SerializeField] public Bullet prefab;
    Factory<Bullet> _factory;
    ObjectPool<Bullet> _objectPool;
    public GameObject[] Firepoint;

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

        var bullet = _objectPool.Get();
        bullet.AddReference(_objectPool);
        bullet.transform.position = Firepoint[0].transform.position;
        bullet.transform.forward = Firepoint[0].transform.forward;

       // NextfireTime = Time.time + 1f / FlyweightPointer.EnemiesShooters.FireRate;
    }

    bool Canfire()
    {

        return Time.time >= NextfireTime;
    }

}
