using UnityEngine;
using System.Collections;

public class tiempoScript : MonoBehaviour {
	public float limitey = -0.01f;
	// Use this for initialization
	void Start () {

		 GameObject.FindWithTag("animales");

	}
	void OnMouseDown(){
		//Debug.Log (rigidbody2D.velocity.y);
		
		Destroy (gameObject);
		
	}
	// Update is called once per frame
	void OnDestroy() {
		//Debug.Log (rigidbody2D.velocity.y);
		if (rigidbody2D.velocity.y < limitey) {
			rigidbody2D.velocity = new Vector2 (0,limitey);
		}
	}

	}

