using UnityEngine;
using System.Collections;

public class turnPointRight : MonoBehaviour {

	public Transform turnStart;
	public Transform turnEnd;
	public LayerMask detectPlayer;
	public bool canTurnRight;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
		canTurnRight = Physics2D.Linecast(turnStart.position, turnEnd.position, detectPlayer);


	}
}



