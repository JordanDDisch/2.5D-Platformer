using UnityEngine;
using System.Collections;

public class Falloff : MonoBehaviour
{

	public GameObject Player;
	public GameObject spawn;

	// Use this for initialization
	void Awake ()
	{
		Player = GameObject.FindGameObjectWithTag("Player");
		spawn = GameObject.FindGameObjectWithTag("Spawn");
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Player.transform.position = spawn.transform.position;
		}
	}

	// Update is called once per frame
	void Update ()
	{
		transform.Rotate(Vector3.up);
		transform.Rotate(Vector3.down);
	}
}
