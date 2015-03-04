using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pinguinoScript : MonoBehaviour {
	public int salud = 100;
	public int puntos = 1;
	private int maxsalud;
	public bool muerte;
	private Text textoFinal;
	private Text texto;

	Animator animation;
	// Use this for initialization
	void Start () {
		animation = GetComponent <Animator> ();
		texto = GameObject.Find ("text_puntos").GetComponent<Text>();
		textoFinal = GameObject.Find ("textoFinal").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (salud <= 0) {
			Destroy (gameObject);
				}
	}

	void OnMouseDown(){
		salud = salud - 100;
		animation.SetInteger ("vida",salud);

	}
	
	void OnDestroy (){
		gameControl.gamecontrol.puntuacion = gameControl.gamecontrol.puntuacion + puntos ;

		texto.text = gameControl.gamecontrol.puntuacion.ToString ();
	}
}
