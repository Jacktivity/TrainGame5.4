using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    public Transform selectEnemyTarget;

    public Transform SelectTrainTarget;

    public int viewingRange;

    public int movementSpeed = 2;

    public int direction;

	public float maxSpeed;

    void Awake()
    {
        selectEnemyTarget = transform;
    }

    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        SelectTrainTarget = go.transform;
    
        
    }

    void Update()
    {
        if (SelectTrainTarget.position.x > selectEnemyTarget.position.x + 1)
        {
            direction = 2;
        }
        else if (SelectTrainTarget.position.x < selectEnemyTarget.position.x - 1)
        {
            direction = -1;
        }
		if (Vector2.Distance (SelectTrainTarget.position, selectEnemyTarget.position) < viewingRange) {
			selectEnemyTarget.position += selectEnemyTarget.right * movementSpeed * direction * Time.deltaTime;
			gameObject.GetComponent<EnemyShooting>().enabled = true;

		} 
		else 
		{
			gameObject.GetComponent<EnemyShooting>().enabled = false;
			Vector3 pos = transform.position;

			Vector3 velocity = new Vector3 (0, maxSpeed * Time.deltaTime, 0);

			pos += transform.rotation * velocity;

			transform.position = pos;
		}
    }
}
    



