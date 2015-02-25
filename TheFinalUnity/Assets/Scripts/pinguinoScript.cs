using UnityEngine;
using System.Collections;

public class pinguinoScript : MonoBehaviour {
	public int salud = 100;
	public int puntos = 1;
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

	void OnDestroy(){
		gameControl.gamecontrol.puntuacion = gameControl.gamecontrol.puntuacion + puntos ;

	}
}
