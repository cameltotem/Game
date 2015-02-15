using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	// Deklarerar variabler
	public float speed = 6f;
	
	
	Vector3 movement; 
	Animator anim;
	Rigidbody playerRigidbody;
	int floorMask;
	float camRayLength = 100f;
	
	// När systemet går igång ska dessa köras
	void Awake()
	{
		floorMask = LayerMask.GetMask ("Floor");
		anim = GetComponent < Animator > ();
		playerRigidbody = GetComponent<Rigidbody> ();
		
	}
	// FixedUpdate måste finnas om det är Rigidbody(Physics)
	void FixedUpdate()
	{
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		float c = Input.GetAxisRaw ("Jump");
		// Glöm för fan inte att unchecka "Freeze position Y" 
		
		Move (h,c,v);
		Turning ();
		Animating (h, v);
		
		
	}
	
	
	void Move (float h, float c,float v)
	{
		movement.Set (h, c, v);
		movement = movement.normalized * speed * Time.deltaTime;
		playerRigidbody.MovePosition (transform.position + movement);
		
	}
	
	void Turning()
	{
		Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit floorHit;
		if (Physics.Raycast (camRay, out floorHit, camRayLength, floorMask)) 
		{
			Vector3 playerToMouse = floorHit.point - transform.position;
			playerToMouse.y = 0f;
			
			Quaternion newRotation = Quaternion.LookRotation (playerToMouse);
			playerRigidbody.MoveRotation (newRotation);
		}
	}
	
	void Animating(float h, float v)
	{
		bool walking = h != 0f || v != 0f;
		anim.SetBool ("IsWalking", walking);
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
}