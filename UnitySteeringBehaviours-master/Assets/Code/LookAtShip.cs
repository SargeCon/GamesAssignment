using UnityEngine;
using System.Collections;

public class LookAtShip : MonoBehaviour {

	public GameObject shipToLookAt;
	public Camera endScene;
	public Camera nextScene;
	public Light alarm;
	public float changeCameraAtThisPosition;
	public float dist;

	private bool sceneHasChanged;

	void Start()
	{
		sceneHasChanged = false;
	}
	void Update () {

		dist = Vector3.Distance(transform.position, shipToLookAt.transform.position);

		if(dist < 750)
		{
			transform.LookAt(shipToLookAt.transform);
		}

		if(dist < 650)
		{
			if(camera.fieldOfView > 25)
				camera.fieldOfView -= 0.5f;
		}

		if(dist < 488 && sceneHasChanged == false)
		{
			sceneHasChanged = true;
			
			Debug.Log("Changing scene");
			endScene.enabled = false;
			nextScene.enabled = true;
			if(alarm != null)
			{
				alarm.enabled = true;
			}
		}

	}
		
}
