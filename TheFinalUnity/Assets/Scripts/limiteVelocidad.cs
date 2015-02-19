using UnityEngine;
using System.Collections;

public class limiteVelocidad : MonoBehaviour {
	public float limitey = -1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (rigidbody2D.velocity.y);
		if (rigidbody2D.velocity.y < limitey) {
			rigidbody2D.velocity = new Vector2 (0,limitey);
				}
	}
}
