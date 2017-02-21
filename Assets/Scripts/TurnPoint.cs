using UnityEngine;
using System.Collections;

public class TurnPoint : MonoBehaviour {

	public Transform turnStart;
	public Transform turnEnd;
	public LayerMask detectPlayer;
	public bool canTurn;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		canTurn = Physics2D.Linecast(turnStart.position, turnEnd.position, detectPlayer);

	
	}
}



