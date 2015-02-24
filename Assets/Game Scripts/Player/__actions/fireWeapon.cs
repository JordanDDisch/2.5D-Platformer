using UnityEngine;
using System.Collections;

public class fireWeapon : MonoBehaviour {

	public Rigidbody projectile;
	private int speed;

	// Use this for initialization
	void Start () {
		speed = 10;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		shootObject ();
	}

	private void shootObject() 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			Rigidbody clone;
			clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
			clone.velocity = transform.TransformDirection(Vector3.up * speed);
		}
	}
}
