using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public Rigidbody player;
	public float speed = 10f;
	public float jumpForce = 10f;
	public bool isGrounded;


	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate (){
		player.AddForce (player.transform.forward * speed * Input.GetAxis("Vertical")); //Vector3.forward
		if(Input.GetAxis("Jump") > 0.1f && isGrounded){
			player.AddForce(new Vector3(player.velocity.x, jumpForce, player.velocity.z));
		}
		if (player.velocity.z > speed)
			player.velocity = new Vector3 (player.velocity.x, player.velocity.y, speed);
	}
}
