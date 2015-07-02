using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	public Transform playerPosition;
	public Transform respawnPlatform;
	public ScoreScript score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (playerPosition.position.x, -10, playerPosition.position.z);
	}

	void OnCollisionEnter(Collision col){
		col.collider.gameObject.transform.position = respawnPlatform.position;
		score.score = 0;
	}
}
