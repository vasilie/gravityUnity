using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

	public GameObject player; 

	[SerializeField]
	private float offset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(player.transform.position.x - offset, 0.0f, -10.0f);
	}
	void FixedUpdate () {
		
	}
}
