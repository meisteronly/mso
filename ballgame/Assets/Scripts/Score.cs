using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour 
{
	public int scoreValue1;
	public int scoreValue2;
	public GameController gameController;

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Ball")
		{
			Destroy (other.gameObject);
			gameController.AddScore(scoreValue1, scoreValue2);
		}
	}



}
