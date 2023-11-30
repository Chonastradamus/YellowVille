using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MementoPlayer : Rewind //Usar interfaces para evitar que se herede
{

    public float life;
    public int Gold;
    public float Speed;


    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        var dir = transform.forward * v;

        dir += transform.right * h;
        transform.position += dir.normalized * Speed * Time.deltaTime;
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            life = Random.Range(0f, 100f);
            Gold = Random.Range(0, 100);
        }
    }
    public override void Load()
    {
        if (!currentState.IsRemember()) return;

        else
        {
        var col = currentState.Remember();
         transform.position = (Vector3)col.paramameters[0];
         transform.rotation = (Quaternion)col.paramameters[1];
         life = (float)col.paramameters[2];
         Gold = (int)col.paramameters[3];
        }

    }
    public override void Save()
    {
        currentState.Rec(transform.position, transform.rotation, life, Gold);
    }

}
