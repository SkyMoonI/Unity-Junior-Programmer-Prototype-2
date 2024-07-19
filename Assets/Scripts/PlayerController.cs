using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	float horizontalInput;
	float verticalInput;
	[SerializeField] float speed = 15.0f;
	[SerializeField] float xRange = 15.0f;
	[SerializeField] float zRange = 15.0f;
	[SerializeField] Vector3 pizzaOffset = new Vector3(0, 0, 1.5f);


	[SerializeField] GameObject pizza;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		CheckXPositionBoundries();
		Move();
		FirePizza();
	}
	void Move()
	{
		horizontalInput = Input.GetAxis("Horizontal");
		verticalInput = Input.GetAxis("Vertical");

		transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);
		transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
	}
	void CheckXPositionBoundries()
	{
		if (transform.position.x > xRange)
		{
			transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
		}
		else if (transform.position.x < -xRange)
		{
			transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
		}
		if (transform.position.z > zRange)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
		}
		else if (transform.position.z < 0)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, 0);
		}


	}
	void FirePizza()
	{

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(pizza, transform.position + pizzaOffset, pizza.transform.rotation);
		}
	}
}
