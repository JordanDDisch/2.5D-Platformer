using UnityEngine;
using System.Collections;

public class rotator : MonoBehaviour {

	private Vector3 mouse_pos;
	private Vector3 object_pos;	
	private float angle;
	private float time = 50.0f;
	// Use this for initialization
	void Start () 
	{
		mouse_pos.z = 0.0f;

	}

	void Update()
	{
	
	}

	// Update is called once per frame
	void FixedUpdate ()
	{

		mouse_pos = Input.mousePosition;	//Get the mouse position 
		object_pos = Camera.main.WorldToScreenPoint (transform.position); //Get the mouse position in world space

		mouse_pos.x = mouse_pos.x - object_pos.x;	//x
		mouse_pos.y = mouse_pos.y - object_pos.y;	//y

		angle = Mathf.Atan2 (mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg - 90;	//Convert mouse position from radiants to degrees
		print (Time.deltaTime * time);
		Vector3 rotationVector = new Vector3 (0, 0, angle);						//Which vector the weapon will rotate on 

		transform.rotation = Quaternion.Euler (rotationVector * Time.deltaTime * time); //Use rotationVector 
	}

}
