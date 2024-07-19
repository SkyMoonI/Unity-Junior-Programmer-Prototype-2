using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
	[SerializeField] float topBound = 30.0f;
	[SerializeField] float lowerBound = -10.0f;
	[SerializeField] float rightBound = 30.0f;
	[SerializeField] float leftBound = -30.0f;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		CheckBoundries();
	}

	private void CheckBoundries()
	{
		if (transform.position.z < lowerBound || transform.position.z > topBound)
		{
			Destroy(gameObject);
		}
		if (transform.position.x < leftBound || transform.position.x > rightBound)
		{
			Destroy(gameObject);
		}
	}
}
