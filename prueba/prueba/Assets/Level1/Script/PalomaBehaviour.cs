using UnityEngine;
using System.Collections;

public class PalomaBehaviour : MonoBehaviour {

	private Vector3 movementVector;
	private bool flip;

	// Use this for initialization
	void Start () {
		flip = false;
		movementVector = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () 
	{
	

		if (Input.GetKey ("left")) {
			if (flip) {
				transform.localEulerAngles -= new Vector3 (0, 180, 0);
				flip = false;
			}
			transform.localPosition -= new Vector3 (0.05f, 0, 0);
			(GetComponent<Animator> ()).SetBool ("isVolando", true);
		} else if (Input.GetKey ("right")) {
			if (!flip) {
				transform.localEulerAngles = new Vector3 (0, 180, 0);
				flip = true;
			}

			transform.localPosition += new Vector3 (0.05f, 0, 0);
			(GetComponent<Animator> ()).SetBool ("isVolando", true);
		} else if (Input.GetKey ("return")) {
			(GetComponent<Animator> ()).SetBool ("isVolando", true);
			transform.localPosition += new Vector3 (0, 0.09f, 0);	
		}
		else {
	
			(GetComponent<Animator>()).SetBool("isVolando",false);
		}

	}
}
