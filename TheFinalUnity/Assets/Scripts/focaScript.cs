using UnityEngine;
using System.Collections;



public class focaScript : MonoBehaviour {
	public int salud = 100;
	public bool vida;
	private int maxsalud;
	public bool muerte;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (salud <= 0) {
			Destroy (gameObject);
		}
	}
	
	void OnMouseDown(){
		salud = salud - 100;
		
	}
	}

