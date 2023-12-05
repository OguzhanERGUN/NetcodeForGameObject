using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetcodeUI : MonoBehaviour
{
	[SerializeField] private Button startClientButton;
	[SerializeField] private Button startHostButton;

	private void Awake()
	{
		startHostButton.onClick.AddListener(() =>
		{
			NetworkManager.Singleton.StartHost();
		});

		startClientButton.onClick.AddListener(() =>
		{
			NetworkManager.Singleton.StartClient();
		});
	}
}
