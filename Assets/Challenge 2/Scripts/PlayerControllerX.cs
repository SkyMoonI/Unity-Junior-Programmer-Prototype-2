using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
	public GameObject dogPrefab;
	float currentTime;
	// Update is called once per frame
	void Update()
	{

		// On spacebar press, send dog
		if (Input.GetKeyDown(KeyCode.Space) && Time.time >= currentTime + 1f)
		{
			currentTime = Time.time;
			Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
		}
	}
}
