using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public float speedrotate;

	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.right * Time.deltaTime * speedrotate);
		transform.Rotate(Vector3.up * Time.deltaTime, Space.World);


	}
}
