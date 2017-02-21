using UnityEngine;
using System.Collections;

public class DamageOutput : MonoBehaviour
{

    public int health = 1;
    public float inulnPeriod = 0;
    float invulnabilityTimer = 0;
    int layer;
    void start()
    {
        layer = gameObject.layer;
    }
    void OnTriggerEnter2D()
    {
        health--;
        invulnabilityTimer = inulnPeriod;
        gameObject.layer = 10;
      
    }
    void Update()
    {
        invulnabilityTimer -= Time.deltaTime;
        if (invulnabilityTimer <= 0)
        {
            gameObject.layer = layer;
        }
        
         if (health <= 0)
        {
            Die();
        }
	
    }
        
    void Die()
    {
        Destroy(gameObject);
    }

    
}
