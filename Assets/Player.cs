using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	[SerializeField]
	private float levelSpeed = 0.04f;
	[SerializeField]
	private float _jump = 8.0f;

	public Vector2 newPos;

	public LayerMask ground_layers;

	bool isGrounded = false;

	public GameObject ground;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {
		newPos = new Vector2 (transform.position.x - 0.051f, transform.position.y - 0.35f);
		isGrounded = Physics2D.OverlapCircle(newPos, 0.3f,  ground_layers); 
		if (Input.GetKeyDown(KeyCode.Space) && isGrounded || Input.touchCount > 0 && isGrounded) {
			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, _jump), ForceMode2D.Impulse);

		}
		float translation = levelSpeed * Time.deltaTime;
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(translation, gameObject.GetComponent<Rigidbody2D>().velocity.y);
		Debug.Log (isGrounded);
	}
	void OnDrawGizmos()
	{
		Gizmos.color = Color.blue;
		Gizmos.DrawSphere(newPos, 0.2f);
	}
}
