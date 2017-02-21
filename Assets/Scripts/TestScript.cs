using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

	public bool canTurnLeft;
	public bool canTurnRight;
	public bool waitingToTurn;
	public GameObject turn;
	public GameObject rightTurn;
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


	}

	// Update is called once per frame
	void Update () {

		canTurnLeft = turn.GetComponent<TurnPoint>().canTurn;
		canTurnRight = rightTurn.GetComponent<turnPointRight>().canTurnRight;


		onLeft = (transform.position.x < -16);
		onRight = (transform.position.x > 16);
		onMid = (transform.position.x > -0.15 && transform.position.x <0.15);
	
		if(Input.GetKeyDown(KeyCode.D))
		{
			if(!turnLeft)
			{
				waitingToTurn = true;
				turnRight = true;
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
				waitingToTurn = true;
				turnLeft = true;
			} 
			else 
			{
				turnRight = false;
			}

		}
		if (canTurnRight && turnRight) 
		{
			onLeft = false;
			onMid = false;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);
			transform.rotation = Quaternion.Euler (0, 0, -rotation);	
			waitingToTurn = false;
		}
		if (canTurnLeft && turnLeft) 
		{
			onRight = false;
			onMid = false;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed, GetComponent<Rigidbody2D> ().velocity.y);
			transform.rotation = Quaternion.Euler (0, 0, rotation);	
			waitingToTurn = false;
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
			if (!waitingToTurn) 
			{
				turnRight = false;
				turnLeft = false;
			}
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
