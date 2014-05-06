using UnityEngine;
using System.Collections;

public class LookAtFix : MonoBehaviour {


	public GameObject box;
	// Update is called once per frame
	void Update () {
		transform.LookAt(box.transform);
	}
}
