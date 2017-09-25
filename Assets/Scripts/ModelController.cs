using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Bigger() {
		transform.localScale += new Vector3 (1, 1, 1);
	}

	public void Smaller() {
		if (transform.localScale.x > 1) {
			transform.localScale -= new Vector3 (1, 1, 1);
		}
	}

	public void RotateRight(){
		transform.RotateAroundLocal (new Vector3 (0, 1, 0), 5);
	}

	public void RotateLeft(){
		transform.RotateAroundLocal (new Vector3 (0, 1, 0), -5);
	}

}
