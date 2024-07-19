using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public int score;

	public int lives = 3;

	public void DecraseLives()
	{
		lives--;
		if (lives <= 0)
		{
			lives = 0;
			Debug.Log("player died Game Over");
		}
		Debug.Log("lives: " + lives);
	}

	public void IncreaseScore()
	{
		score++;
		Debug.Log("score: " + score);

	}

}
