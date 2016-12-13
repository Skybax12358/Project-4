using UnityEngine;
using System.Collections;

public class PlayerLock : MonoBehaviour {

	public float Speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition += new Vector3(0f,0f,Speed * Time.deltaTime);
	}
}
