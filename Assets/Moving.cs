using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {

	[SerializeField]
	private float levelSpeed = 0.04f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(levelSpeed, 0.0f, 0.0f);
	}
}
