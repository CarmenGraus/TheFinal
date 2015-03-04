using UnityEngine;
using System.Collections;

public class puntuacion_Script : MonoBehaviour {
	int points = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameControl.gamecontrol.puntuacion = gameControl.gamecontrol.puntuacion +1 ;
	}
}
