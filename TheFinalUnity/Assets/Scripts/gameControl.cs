using UnityEngine;
using System.Collections;

public class gameControl : MonoBehaviour {
	
	public int puntuacion = 0;
	public int vidas = 2;
	
	public static gameControl gamecontrol;
	
	void Awake(){
		if (gamecontrol == null) {
			gamecontrol = this;
			DontDestroyOnLoad (gameObject);
		} else if (gamecontrol != this) {
			Destroy (this);
		}
	}
	

}