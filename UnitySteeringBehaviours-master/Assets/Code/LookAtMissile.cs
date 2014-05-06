using UnityEngine;
using System.Collections;

namespace BGE
{
	public class LookAtMissile : MonoBehaviour {

		public GameObject missile;
		public GameObject reinforce;
		public Camera reinforceShipView;
		public float dist;
		private bool sceneHasChanged;
		
		void Start()
		{
			sceneHasChanged = false;
		}
		
		// Update is called once per frame
		void Update () {

			dist = Vector3.Distance(transform.position, missile.transform.position);
			
			if(dist < 750)
			{
				transform.LookAt(missile.transform);
			}
			if(dist < 470)
			{
				if(camera.fieldOfView < 55)
					camera.fieldOfView += 1.0f;
			}

			if(dist <420 && sceneHasChanged ==false)
			{
				camera.enabled = false;
				reinforceShipView.enabled = true;
				reinforce.GetComponent<SteeringBehaviours>().ArriveEnabled = true;
				sceneHasChanged = true;
			}
		}
	}
}
