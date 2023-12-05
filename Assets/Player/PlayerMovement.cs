using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour
{
	[SerializeField] private float verticalSpeed;
	[SerializeField] private float horizontalSpeed;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (!IsOwner) return;

		if (Input.GetAxis("Horizontal") != 0)
		{
			transform.Translate(Vector3.forward * Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime *-1);
		}
		if(Input.GetAxis("Vertical") != 0)
		{
			transform.Translate(Vector3.left * Input.GetAxis("Vertical") * verticalSpeed * Time.deltaTime *-1);

		}
	}
}
