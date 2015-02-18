using UnityEngine;
using System.Collections;

public class generadorScript : MonoBehaviour {

	public GameObject[] pinguino;
	public float tiempoespera = 3;
	float timer = 0;
	Vector3 posicion;
	// Use this for initialization
	void Start () {
		posicion = transform.position; 
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > timer) {
			var altura = Random.Range(-1.5f,1.5f);
			var tipopinguino = Random.Range (0,pinguino.Length);
			
			var nuevopinguino = (GameObject)Instantiate(
				pinguino[tipopinguino],
				new Vector3(posicion.x,posicion.y+altura,posicion.z), 
				transform.rotation);
			
			Destroy (nuevopinguino,tiempoespera*3);
			
			timer = Time.time+tiempoespera;
		}
	}
}