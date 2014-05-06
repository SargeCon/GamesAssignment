using UnityEngine;
using System.Collections;


namespace BGE
{
	public class FireMissiles : MonoBehaviour {

		public GameObject ship;
		public GameObject hitPoint;
		public GameObject explosion;
		public GameObject startPos;

		public float firePos;

		// Update is called once per frame
		void Update () 
		{
			if(ship.transform.position.z > firePos)
			{
				transform.GetComponent<SteeringBehaviours>().seekTargetPos = hitPoint.transform.position;
				transform.GetComponent<SteeringBehaviours>().ArriveEnabled = true;
			}
			if(Vector3.Distance(transform.position, hitPoint.transform.position) < 5.0f)
			{
				transform.position = startPos.transform.position;
				Instantiate(explosion, hitPoint.transform.position, hitPoint.transform.rotation);
			}
		}
	}
}
