using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] objects;
	private static int spawnCount;
	public int targetCount;

	// Use this for initialization
	void Start () {
		if (spawnCount < targetCount) {
			Invoke("Spawn", 0);
			spawnCount++;
		}
	}

	void Spawn(){
		Instantiate(objects[Random.Range (0, objects.Length)], 
		            transform.position, transform.rotation);
	}
}
