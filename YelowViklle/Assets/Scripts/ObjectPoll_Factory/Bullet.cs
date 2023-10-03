using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float counter;
    public float lifetime;
    ObjectPool<Bullet> _objectPool;


    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        counter += Time.deltaTime;

        if (counter >= lifetime)
        {
            _objectPool.StockAdd(this);
        }
    }

    public void AddReference(ObjectPool<Bullet> op)
    {
        _objectPool = op;
    }

    public static void TurnOff(Bullet bullet)
    {
        bullet.gameObject.SetActive(false);
    }

    public static void TurnOn(Bullet bullet)
    {
        bullet.counter = 0;
        bullet.gameObject.SetActive(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Idamagable damagableInterface = collision.gameObject.GetComponent<Idamagable>();

        if (collision.gameObject.layer == 7 && damagableInterface != null)
        {
            damagableInterface.TakeDamage(5);
            TurnOff(this);
            _objectPool.StockAdd(this);
        }
    }
}
