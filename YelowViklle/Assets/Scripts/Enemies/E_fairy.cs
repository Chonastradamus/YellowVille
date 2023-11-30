using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_fairy : EnemiesDamage
{
    public GameObject[] EntitiesToSpawn;

    public Transform[] SpawnPoints;


    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        if (IsInChaseRange)
        {
            Explote();
        }
    }


    public void Explote()
    {
        StartCoroutine(ExplosionTime(EntitiesToSpawn, SpawnPoints));
    }

    IEnumerator ExplosionTime(GameObject[] Spawner, Transform[] Spawponts)
    {

        yield return new WaitForSeconds(3);
        foreach (var item in Spawner)
        {
            foreach (var Item2 in Spawponts)
            {

             //GameObject lootGameobject = Instantiate(Spawner[item], Spawponts[Item2], Vector3.zero);

            }

        }

        this.gameObject.SetActive(false);

    }
    protected override void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, checkRadius);
    }
}
