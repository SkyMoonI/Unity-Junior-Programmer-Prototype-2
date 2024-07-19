using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
	GameManager gameManager;
	// Start is called before the first frame update
	void Start()
	{
		gameManager = FindObjectOfType<GameManager>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			gameManager.DecraseLives();
			Destroy(gameObject);
		}
		else if (other.gameObject.CompareTag("Enemy"))
		{
			other.gameObject.GetComponent<AnimalHunger>().FeedAnimal();
			Destroy(gameObject);
		}

	}
}
