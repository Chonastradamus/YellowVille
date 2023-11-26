using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoweer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var hechizero = other.GetComponent<Imagic>();


        if(hechizero != null)
        {
           
            this.gameObject.SetActive(false);
            hechizero.AddMagic(new FireMagic(hechizero.GetActualMagic()));
        }
    }


}
