using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_move : MonoBehaviour {
	public GameObject player;
	private Vector3 Camera_Offset;
	// Use this for initialization
	void Start () {
		Camera_Offset = transform.position - player.transform.position;


	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + Camera_Offset;
	}
}
