using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Totem : MonoBehaviour
{
    [Header("Detecction")]
    [SerializeField] public float checkRadius;
    public LayerMask whatIsPlayer;
    public Transform[] players;
    [SerializeField] public bool IsInChaseRange;



    private void Update()
    {
        detection();

        if (!IsInChaseRange)
        {
            this.gameObject.SetActive(false);
            GameManager.instance.LoadManager();
        }

    }
    public void detection()
    {
        IsInChaseRange = Physics.CheckSphere(transform.position, checkRadius, whatIsPlayer);
    }


    protected virtual void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireSphere(transform.position, checkRadius);
    }

}
