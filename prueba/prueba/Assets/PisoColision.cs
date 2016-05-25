using UnityEngine;
using System.Collections;

public class PisoColision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D col){ //cuando chocan la primera vez
		Debug.Log("entro en colision");
	}

	void OnCollisionStay2D(Collision2D col){ // mientras estan en contacto
		Debug.Log ("Esta en colision con:" + col.gameObject.name);
	}

	void OnCollisionExit2D(Collision2D col){ //cuando dejan de estar en contacto
	
	}
}
