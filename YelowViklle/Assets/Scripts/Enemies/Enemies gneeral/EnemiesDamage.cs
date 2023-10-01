using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemiesDamage : Enemies_Behavior
{
    public bool Isattacking;
    protected virtual void OnCollisionEnter(Collision collision)
    {
 
        Idamagable damagableInterface = collision.gameObject.GetComponent<Idamagable>();
        if (collision.gameObject.layer == whatIsPlayer || damagableInterface != null)
        {
            Isattacking = true;
            if (Isattacking)
            {
             damagableInterface.TakeDamage(FlyweightPointer.enemies.Damage);  
             Isattacking = false;
           
            }
        
        }
    }

}
