using UnityEngine;
using System.Collections;

public class cameraSwitch : MonoBehaviour {

	private bool fov;

	public Camera firstPersonCamera;
	public Camera thirdPersonCamera;

	// Use this for initialization
	void Start () {
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.V)) {
			fov = !fov;
		}
		firstPersonCamera.enabled = !fov;
		thirdPersonCamera.enabled = fov;
	}
}
