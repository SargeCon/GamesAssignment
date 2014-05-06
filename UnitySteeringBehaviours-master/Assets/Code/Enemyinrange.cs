using UnityEngine;
using System.Collections;

namespace BGE
{
	public class Enemyinrange : MonoBehaviour {

		public GameObject enemy;

		// Update is called once per frame
		void Update () 
		{
			if(enemy.transform.position.z < 50)
			{
				transform.GetComponent<SteeringBehaviours>().PursuitEnabled = true;
			}
		}
	}
}
