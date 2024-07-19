using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	[SerializeField] GameObject[] animalPrefabs;

	[Header("Spawn Delay")]
	[SerializeField] float spawnStartDelay = 2.0f;
	[SerializeField] float spawnInterval = 1.5f;

	[Header("Horizontal")]
	[SerializeField] float spawnRangeX = 15.0f;
	[SerializeField] float spawnPosZ = 15.0f;

	[Header("Vertical")]
	[SerializeField] float maxSpawnRangeZ = 15.0f;
	[SerializeField] float minSpawnRangeZ = 5.0f;
	[SerializeField] float spawnPosX = 20.0f;

	float[] spawnRotations = new float[] { -90f, 180f, 90f };
	// Start is called before the first frame update
	void Start()
	{
		InvokeRepeating(nameof(SpawnRandomAnimal), spawnStartDelay, spawnInterval);
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.S))
		{
			SpawnRandomAnimal();
		}
	}
	float GetRandomRotation()
	{
		return spawnRotations[Random.Range(0, spawnRotations.Length)];
	}

	void SpawnRandomAnimal()
	{
		float randomRotation = GetRandomRotation(); // -90f, 0f, 90f

		int animalIndex = Random.Range(0, animalPrefabs.Length); // 0, 1, 2

		Vector3 spawnPos = new Vector3();
		float positionX;
		float positionZ;

		Quaternion rotation = Quaternion.identity;

		switch (randomRotation)
		{
			case -90f:
				// rotation of animal is assigned
				rotation = Quaternion.Euler(0f, -90f, 0f);
				// position of animal is assigned
				positionZ = Random.Range(minSpawnRangeZ, maxSpawnRangeZ);
				spawnPos = new Vector3(spawnPosX, 0, positionZ);
				break;
			case 180f:
				// rotation of animal is assigned
				rotation = Quaternion.Euler(0f, 180f, 0f);
				// position of animal is assigned
				positionX = Random.Range(-spawnRangeX, spawnRangeX);
				spawnPos = new Vector3(positionX, 0, spawnPosZ);
				break;
			case 90f:
				// rotation of animal is assigned
				rotation = Quaternion.Euler(0f, 90f, 0f);
				// position of animal is assigned
				positionZ = Random.Range(minSpawnRangeZ, maxSpawnRangeZ);
				spawnPos = new Vector3(-spawnPosX, 0, positionZ);
				break;
		}

		Instantiate(animalPrefabs[animalIndex], spawnPos, rotation);
	}



}
