using UnityEngine;
using System.Collections;


public class Player2Controller : MonoBehaviour
{
	//initialize the speed so it can be called by the code or changed in the editor
	public float speed;
	
	void FixedUpdate ()
	{
		//Grabs the Input settings from Unity
		float moveHorizontal = Input.GetAxis ("Horizontal_2");
		float moveVertical = Input.GetAxis ("Vertical_2");
		
		//this allows the player to move in 2 dimensions
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rigidbody2D.velocity = movement * speed;
		
	}
	
}