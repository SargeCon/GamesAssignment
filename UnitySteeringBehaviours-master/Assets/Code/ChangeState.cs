using UnityEngine;
using System.Collections;

namespace BGE
{
	public class ChangeState : MonoBehaviour {

		public Camera sceneTwo;
		public Camera sceneThree;

		public Light alarm;

		private bool sceneHasChanged;
		
		void Start()
		{
			sceneHasChanged = false;
		}

		void Update () 
		{
			if(sceneTwo.enabled == true)
			{
				transform.GetComponent<SteeringBehaviours>().ArriveEnabled = true;
			}
			if(transform.position.z > -433 && alarm != null && sceneHasChanged == false)
			{
				alarm.enabled = false;
				sceneTwo.enabled = false;
				sceneThree.enabled = true;
				sceneHasChanged = true;
			}
		}
	}
}
