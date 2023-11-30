using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egolem : EnemiesDamage
{
    public Transform[] points;

    int PointNumber;
    //TP2 - *Juan ignacio Guastini*.

    protected override void Update()
    {

        golemMovement();

    }

    void golemMovement()
    {
        points = target;

        if (transform.position == points[PointNumber].position)
        {
            PointNumber = (PointNumber + 1) % points.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, points[PointNumber].position, FlyweightPointer.enemies.speed * Time.deltaTime);
    }


    protected override void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, checkRadius);
    }
}

