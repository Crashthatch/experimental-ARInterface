using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad (gameObject);
		// If the same type of gameobject is present in scene already than it is destroyed useful when reloading the same scene
		if (FindObjectsOfType(GetType()).Length > 1)
		{
			Destroy(gameObject);
		}
		transform.localPosition = Vector3.zero;
		transform.localRotation = Quaternion.identity;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
