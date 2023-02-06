using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    Rigidbody2D rigidbody2D;
    
    void Awake()
    {
       rigidbody2D = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
      if(transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other)
    {
      //we also adda a debug log to know what the projectile  
      Debug.Log("Projecile Collisionwith " + other.gameObject);
      Destroy(gameObject);
    }
    public void Launch(Vector2 direction, float force)
    {
        rigidbody2D.AddForce(direction * force);
    }
}
