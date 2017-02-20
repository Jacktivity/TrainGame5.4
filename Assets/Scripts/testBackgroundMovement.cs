using UnityEngine;
using System.Collections;

public class testBackgroundMovement : MonoBehaviour 
{
		public float scrollSpeed;
		public float tileSizeY;

		private Vector3 startPosition;
		
		private Vector3 forward;

		void Start ()
		{
			startPosition = transform.position;
		forward = new Vector3(0,1,0);
		}

		void Update ()
		{
			float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeY);
			transform.position = startPosition + forward * newPosition;
		}

}
