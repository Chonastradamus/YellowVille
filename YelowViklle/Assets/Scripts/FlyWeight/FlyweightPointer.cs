using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FlyweightPointer
{
   
    public static readonly FlyWeightEnemies enemies = new FlyWeightEnemies()
    {
        speed = 2,
        Damage = 5,
        Life = 10
    };

}
