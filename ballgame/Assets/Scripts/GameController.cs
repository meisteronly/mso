using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	//Allows me to edit the x and y values for the players' spawns.
	public Vector2 spawnValues;
	public Vector2 ballValues;

	public GameObject player1;
	public GameObject player2;
	public GameObject ball;

	public GUIText player1Score;
	public GUIText player2Score;
	private int score1;
	private int score2;

	// Use this for initialization
	void Start ()
	{
		score1 = 0;
		score2 = 0;
		UpdateScore ();
		PlayerSpawn ();
		BallSpawn ();
	}

	//Spawns the player.
	void PlayerSpawn () 
	{
		Vector3 spawnPosition1 = new Vector3 (spawnValues.x, spawnValues.y, 0);
		Vector3 spawnPosition2 = new Vector3 (-spawnValues.x, spawnValues.y, 0);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate (player1, spawnPosition1, spawnRotation);
		Instantiate (player2, spawnPosition2, spawnRotation);
	}

	void BallSpawn ()
	{
		Vector3 ballPosition = new Vector3 (ballValues.x, ballValues.y, 0);
		Quaternion ballRotation = Quaternion.identity;
		Instantiate (ball, ballPosition, ballRotation);
	}

	public void AddScore (int newScoreValue1, int newScoreValue2)
	{
		score1 += newScoreValue1;
		score2 += newScoreValue2;
		UpdateScore ();
	}

	void UpdateScore ()
	{
		player1Score.text = "Red: " +score1;
		player2Score.text = "Yellow: " +score2;
	}

}
