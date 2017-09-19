using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public float movement_Speed = 0.0f;
	public float jump_Height = 0;
	private Rigidbody myRigidbody;
	//lol fug :DD :DDD
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Move
		//-------------------------------------------------------------------------------------------------------------------
		if (Input.GetKey (KeyCode.W))
			transform.Translate (new Vector3 (0, 0, movement_Speed));
		if (Input.GetKey (KeyCode.S))
			transform.Translate (new Vector3 (0, 0, -movement_Speed));
		if (Input.GetKey (KeyCode.A))
			transform.Translate (new Vector3 (-movement_Speed, 0, 0));
		if (Input.GetKey (KeyCode.D))
			transform.Translate (new Vector3 (movement_Speed, 0, 0));
		//Should have some sort of opposite force applied to make it more smooth, and lock rotation to avoid wonky movement.
		//Jump
		//-------------------------------------------------------------------------------------------------------------------
		if (Input.GetKeyDown (KeyCode.Space))
			transform.Translate (new Vector3 (0, jump_Height, 0));
		//I should learn how to make a jump script... Also locked rotation to avoid wonky movement.
		//-------------------------------------------------------------------------------------------------------------------
		//~~~~~({[!!!All in all - Need a smoother feeling jump, need a proper jump that isn't a teleport, need a locked rotation or requires a tracking camera]})!!!~~~~~
		//While the movement works and is precise, it feels bad.
		//Technically, yes, the jump goes up, but it's more of a teleport.
	}   
}
