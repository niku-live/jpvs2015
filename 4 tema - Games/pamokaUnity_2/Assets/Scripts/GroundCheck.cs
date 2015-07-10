using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour {

	private PlayerMove player;

	void Start(){
		player = gameObject.GetComponentInParent<PlayerMove>();
	}

	void OnTriggerEnter(Collider col){
	
		player.isGrounded = true;
	
	}

	void OnTriggerExit(Collider col){
	
		player.isGrounded = false;
	
	}
}
