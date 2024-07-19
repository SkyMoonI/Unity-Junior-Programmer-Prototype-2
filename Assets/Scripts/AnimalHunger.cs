using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
	[SerializeField] Slider slider;

	[SerializeField] int amountToBeFed = 1;
	[SerializeField] int maxAmountToBeFed = 1;
	[SerializeField] int currentHunger = 0;


	GameManager gameManager;


	// Start is called before the first frame update
	void Start()
	{
		slider.value = 0;
		slider.maxValue = maxAmountToBeFed;
		gameManager = FindObjectOfType<GameManager>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void FeedAnimal()
	{
		currentHunger += amountToBeFed;
		slider.value = currentHunger;
		if (currentHunger == maxAmountToBeFed)
		{
			Destroy(gameObject);
			gameManager.IncreaseScore();
		}

	}
}
