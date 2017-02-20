using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

	public bool turnLeft;
	public bool turnRight;
	public bool onLeft;
	public bool onRight;
	public bool onMid;
	public int speed;
	public float rotation;

	// Use this for initialization
	void Start () 
	{

		rotation = 45;
	}

	// Update is called once per frame
	void Update () {

		onLeft = (transform.position.x < -16);
		onRight = (transform.position.x > 16);
		onMid = (transform.position.x > -0.15 && transform.position.x <0.15);
	
		if(Input.GetKeyDown(KeyCode.D))
		{
			if(!turnLeft)
			{
				turnRight = true;
				onLeft = false;
				onMid = false;
				GetComponent<Rigidbody2D>().velocity = new Vector2 (speed, GetComponent<Rigidbody2D>().velocity.y);
				transform.rotation = Quaternion.Euler(0,0,-rotation);	
			}
			else
			{
				turnLeft = false;
			}
	

		}
		if(Input.GetKeyDown(KeyCode.A))
		{
			if (!turnRight)
			{
				turnLeft = true;
				onRight = false;
				onMid = false;
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed, GetComponent<Rigidbody2D> ().velocity.y);
				transform.rotation = Quaternion.Euler(0,0,rotation);	
			} 
			else 
			{
				turnRight = false;
			}

		}
		if (onLeft) 
		{
			turnLeft = false;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, GetComponent<Rigidbody2D> ().velocity.y);
			transform.position = new Vector2(-16f, GetComponent<Rigidbody2D>().position.y);
			transform.rotation = Quaternion.Euler(0,0,0);	
		}
		if (onRight) 
		{
			turnRight = false;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, GetComponent<Rigidbody2D> ().velocity.y);
			transform.position = new Vector2(16f, GetComponent<Rigidbody2D>().position.y);
			transform.rotation = Quaternion.Euler(0,0,0);
		}
		if (onMid) 
		{
			turnRight = false;
			turnLeft = false;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, GetComponent<Rigidbody2D> ().velocity.y);
			transform.position = new Vector2(0.0f, GetComponent<Rigidbody2D>().position.y);
			transform.rotation = Quaternion.Euler(0,0,0);
		}
		if(!turnLeft && !turnRight)
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, GetComponent<Rigidbody2D> ().velocity.y);
		}
	
	}
}
