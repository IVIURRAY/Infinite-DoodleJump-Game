using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float bottomOfScreen = 5.5f;
	
	// Update is called once per frame
	void Update () {

		// If our doodler y is greater than the camera's y then move it up.
		if (target.position.y > transform.position.y)
		{
			transform.position = new Vector3(transform.position.x, target.position.y, transform.position.z);
		}

		if (target.position.y < (transform.position.y - bottomOfScreen))
		{
			SceneManager.LoadScene(0);
		}

	}
}
