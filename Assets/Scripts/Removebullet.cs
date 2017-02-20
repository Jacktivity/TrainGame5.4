using UnityEngine;
using System.Collections;

public class Removebullet : MonoBehaviour {

    public float timer = 0;
	public float delay = 20;

	//stuff for overlay circle
	public LayerMask everything;
	public Transform bullet;
	public bool hitSomething;
	public float radius;

	void start()
	{
	}
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;
        if (timer >= delay)
        {
            Destroy(gameObject);
			timer = 0;
        }
		timer++;

		//Overlap circle, if something with player tag is inside, kill me
		Collider2D hitSomething = Physics2D.OverlapCircle(bullet.transform.position, radius, everything);
		if(hitSomething)
		if(hitSomething.tag == "Enemy")
		{
			Destroy(gameObject);
			hitSomething.transform.GetComponent<EnemyHealth> ().TakeDamage(1); // this has been set to one becaus the max health is 3, meaning after 3 hits from the projectile the player will die
		}
	}
}
