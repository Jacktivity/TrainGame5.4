using UnityEngine;
using System.Collections;

public class FindPlayerTrain : MonoBehaviour {

	public float rotationSpeed = 90f;

	Transform player;

	// Update is called once per frame
	void Update () {
		if(player == null) {
			// locate player train
			GameObject go = GameObject.FindWithTag ("Player");

			if(go != null) {
				player = go.transform;
			}
		}


		if(player == null)
			return;	// not found player try again

		// Player is found locate target and face it.

		Vector3 direction = player.position - transform.position;
        direction.Normalize();

		float zAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;

		Quaternion desiredRot = Quaternion.Euler( 0, 0,zAngle );

		transform.rotation = Quaternion.RotateTowards( transform.rotation, desiredRot, rotationSpeed * Time.deltaTime);

	}
}
