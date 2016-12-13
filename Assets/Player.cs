using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float Speed;

	public GameObject Wall1;
	public GameObject Wall2;
	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		Movement();

	}

	void Movement()
	{
		transform.localPosition += transform.forward * Speed * Time.deltaTime;
		transform.forward = Vector3.Normalize (new Vector3 (Input.GetAxis ("Horizontal"), 0f, Input.GetAxis ("Vertical")));
	}


	public void OnCollsionEnter (GameObject other)
	{
		if (other.gameObject.tag == "Wall1")
			transform.position = new Vector3(Wall2.transform.position.x ,0f, Wall2.transform.position.z);

		else if (other.gameObject.tag == "Wall2")
			transform.position = new Vector3(Wall1.transform.position.x ,0f, Wall1.transform.position.z);
	}	
}
