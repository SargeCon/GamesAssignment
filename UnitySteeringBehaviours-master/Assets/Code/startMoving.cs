using UnityEngine;
using System.Collections;


namespace BGE
{
	public class startMoving : MonoBehaviour {

		public Camera sceneThree;
		// Update is called once per frame
		void Update () 
		{
			if(sceneThree.enabled == true)
			{
				transform.GetComponent<SteeringBehaviours>().ArriveEnabled = true;
			}
		}
	}
}
