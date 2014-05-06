using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;


namespace BGE
{
	public class CheckForAttack : MonoBehaviour {


		float timeShot = 0.25f;
		public GameObject enemyGameObject;
		
		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		public void Update()
		{
			float range = 100.0f;
			timeShot += Time.deltaTime;
			float fov = Mathf.PI / 4.0f;
			// Can I see the enemy?
			
			if ((enemyGameObject.transform.position - transform.position).magnitude < range)
			{
				float angle;
				Vector3 toEnemy = (enemyGameObject.transform.position - transform.position);
				toEnemy.Normalize();
				angle = (float) Math.Acos(Vector3.Dot(toEnemy, transform.forward));
				if (angle < fov)
				{
					if (timeShot > 0.25f)
					{
						GameObject lazer = new GameObject();
						lazer.AddComponent<Lazer>();
						lazer.transform.position = transform.position;
						lazer.transform.forward = transform.forward;
						timeShot = 0.0f;
					}
				}
			}
		}
	}
}
