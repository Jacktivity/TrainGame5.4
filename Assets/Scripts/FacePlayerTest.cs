using UnityEngine;
using System.Collections;

public class FacePlayerTest : MonoBehaviour {

	public float rotSpeed = 90f;
	public GameObject train;


	// Update is called once per frame
	void Update ()
	{
		Vector3 player = train.GetComponent<Rigidbody2D>().transform.position;
		transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(player.y - transform.position.y, player.x - transform.position.x) * Mathf.Rad2Deg - 90);
	}
}
