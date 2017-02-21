using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour
{

    public Vector3 bulletSet = new Vector3(0, 0.2f, 0);

    public GameObject bulletPrefab;

    int bulletLayer;

    public float bulletDelay = 0.25f;
    float cooldownTimer = 0;

  
    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if (cooldownTimer <= 0)
        {
            
			cooldownTimer = bulletDelay;

			Vector3 offset = transform.rotation * bulletSet;

			GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
			bulletGO.layer = gameObject.layer;

        }
    }
}


