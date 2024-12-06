using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myRigidbody;
    [SerializeField] private float bulletSpeed;
    private float myDamage;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody.velocity = transform.up * bulletSpeed;
        Destroy(gameObject, 4f);
    }

    public void InitializeBullet(float damageParam)
    {
        myDamage = damageParam;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.rigidbody && collision.rigidbody.CompareTag("Enemy"))
        {
            collision.rigidbody.GetComponent<Character>().healthValue.DecreaseHealth(myDamage);
        }

        Destroy(gameObject);
    }
}
