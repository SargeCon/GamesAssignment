using UnityEngine;
using System.Collections;

public class SwitchScene : MonoBehaviour {

	public Camera endScene;
	public Camera nextScene;
	public Light alarm;
	public float changeCameraAtThisPosition;

	private bool sceneHasChanged;

	void Start()
	{
		sceneHasChanged = false;
	}

	// Update is called once per frame
	void Update () {
		if(transform.position.z >= changeCameraAtThisPosition && sceneHasChanged == false)
		{
			sceneHasChanged = true;
			endScene.enabled = false;
			nextScene.enabled = true;
			if(alarm != null)
			{
				alarm.enabled = true;
			}
		}
	}
}
