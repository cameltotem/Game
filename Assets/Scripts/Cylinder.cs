using UnityEngine;
using System.Collections;

public class Cylinder : MonoBehaviour {
	
	public float speedrotates;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.right * Time.deltaTime * speedrotates);
		transform.Rotate(Vector3.up * Time.deltaTime, Space.World);


	}
}