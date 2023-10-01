using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FlyweightPointer
{
   
    public static readonly FlyWeightEnemies enemies = new FlyWeightEnemies()
    {
        speed = 2,
        Damage = 5,
        Maxlife = 10
    };

    public static readonly FlyWeightEnemiesShoot EnemiesShooters = new FlyWeightEnemiesShoot()
    {
        FireRate = 2,
    };

    public static readonly FlyWeightEnemiesExplosive EnmeiesExplosive = new FlyWeightEnemiesExplosive()
    {
           explosionTime = 3,
    };

}
