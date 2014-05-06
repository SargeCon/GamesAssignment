using UnityEngine;
using System.Collections;

public class CameraWarp : MonoBehaviour {

	// Use this for initialization

	public GameObject ship;
	public float warpinDist;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(ship.transform.position.z > warpinDist)
		{
			if(camera.fieldOfView >= 70)
				camera.fieldOfView -=5;
		}

	}
}
