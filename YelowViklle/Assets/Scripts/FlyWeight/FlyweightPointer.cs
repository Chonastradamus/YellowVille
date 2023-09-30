using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FlyweightPointer
{
    public static readonly Flyweight EnemyBase = new Flyweight()
    {
        speed = 5,
        Damage = 5,
        maxLife = 10

    };

    public static readonly Flyweight E_WOLF = new Flyweight()
    {
        
    };

}
