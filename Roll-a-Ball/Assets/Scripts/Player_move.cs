using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_move : MonoBehaviour {
	public Rigidbody player_rb;
	public float speed;

	void Start(){
		player_rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float Move_h = Input.GetAxis ("Horizontal");
		float Move_v = Input.GetAxis ("Vertical");

		Vector3 move_vec = new Vector3 (Move_h, 0, Move_v);

		player_rb.AddForce (move_vec * speed); 
	}
}
